using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Bak.Report.Application.Contracts.Auths;
using Bak.Report.Application.Contracts.Base;
using Bak.Report.Common.Base;
using Bak.Report.Common.Extensions;
using Bak.Report.Domain.Auths.Repositories;
using Bak.Report.Domain.Base;
using Bak.Report.Domain.Base.Repositories;
using Bak.Report.Domain.Settings;
using Bak.Report.Domain.Shared;
using Bak.Report.Domain.Shared.Enums;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Bak.Report.Application.Auths
{
    public class AuthService : ApplicationService, IAuthService
    {
        private readonly IThirdTicketRepository _thirdTicketRepository;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IFactorRepository _factorRepository;

        public AuthService(
            IThirdTicketRepository thirdTicketRepository,
            IHttpClientFactory httpClientFactory, 
            IFactorRepository factorRepository)
        {
            _thirdTicketRepository = thirdTicketRepository;
            _httpClientFactory = httpClientFactory;
            _factorRepository = factorRepository;
        }

        /// <summary>
        /// 获取预授权码
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetPreAuthCodeAsync()
        {
            var accessToken = await GetAccessToken();

            var client = _httpClientFactory.CreateClient();

            var content = new StringContent("{" + $"\"component_appid\":\"{AppSettings.Weixin.AppId}\"" + "}");

            var response = await client.PostAsync(UrlsConfig.CreatePreAuthCode.FormatWith(accessToken.Result), content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                var jObj = json.ToJObject();

                return jObj["pre_auth_code"]?.ToString();
            }

            return "";
        }

        /// <summary>
        /// 获取令牌
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResult<string>> GetAccessToken()
        {
            var result = new ServiceResult<string>();

            var factor = await _factorRepository.FindAsync(x => x.Type == FactorType.AccessToken);

            if (!string.IsNullOrWhiteSpace(factor?.Vaule))
            {
                result.IsSuccess(accessToken);
            }
            else
            {
                var input = new
                {
                    component_appid = AppSettings.Weixin.AppId,
                    component_appsecret = AppSettings.Weixin.AppSecret,
                    component_verify_ticket = await _thirdTicketRepository.GetTicketAsync()
                };

                var client = _httpClientFactory.CreateClient();
                var content = new StringContent(input.ToJson());

                var response = await client.PostAsync(UrlsConfig.GetAccessToken, content);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    var jObj = json.ToJObject();

                    accessToken = jObj["component_access_token"]?.ToString();

                    if (string.IsNullOrWhiteSpace(accessToken))
                    {
                        result.IsFailed("获取令牌失败");
                    }
                    else
                    {
                        result.IsSuccess(accessToken);
                        _factorRepository.UpdateAsync()
                        await _thirdAccessTokenRepository.UpdateAccessTokenAsync(accessToken, jObj["expires_in"].TryToInt());
                    }
                }
                else
                {
                    result.IsFailed(ReportConsts.ResponseText.ERR_NETWORK);
                }
            }

            return result;
        }

        /// <summary>
        /// 创建授权页面地址
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResult<string>> CreateAuthPageAsync(string redirectUrl)
        {
            var result = new ServiceResult<string>();

            var preAuthCode = await GetPreAuthCodeAsync();
            if (string.IsNullOrWhiteSpace(preAuthCode))
            {
                result.IsFailed("获取预授权码失败");
                return result;
            }

            var url = UrlsConfig.ComponentLoginPage.FormatWith(AppSettings.Weixin.AppId, preAuthCode, redirectUrl, 3);

            result.IsSuccess(url);

            return result;
        }

        /// <summary>
        /// 新增授权信息
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResult> CreateAuthorizerAsync(string authCode, int expiresIn)
        {
            var result = new ServiceResult();

            var accessToken = await _thirdAccessTokenRepository.GetAccessTokenAsync();

            var client = _httpClientFactory.CreateClient();
            var model = new
            {
                component_appid = AppSettings.Weixin.AppId,
                authorization_code = authCode
            };

            var content = new StringContent(model.ToJson());

            var response = await client.PostAsync(UrlsConfig.QueryAuth.FormatWith(accessToken), content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                var jObj = json.ToJObject();

                var entity = new MerchanAuthorization()
                {


                };

                result.IsSuccess(accessToken);
                await _merchanAuthorizationRepository.InsertAsync(entity);
            }
            else
            {
                result.IsFailed(ReportConsts.ResponseText.ERR_NETWORK);
            }

            return result;
        }

        /// <summary>
        /// 查询授权信息
        /// </summary>
        /// <returns></returns>
        //public async Task<ServiceResult<PagedResultDto<MerchanAuthorizationDto>>> QueryMerchanAuthAsync(PagedAndSortedResultRequestDto input)
        //{
        //    var result = new ServiceResult<PagedResultDto<MerchanAuthorizationDto>>();

        //    var count = await _merchanAuthorizationRepository.GetCountAsync();

        //    var list = await _merchanAuthorizationRepository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting);

        //    result.IsSuccess(new PagedResultDto<MerchanAuthorizationDto>
        //    {
        //        TotalCount = count,
        //        Items = ObjectMapper.Map<List<MerchanAuthorization>, List<MerchanAuthorizationDto>>(list)
        //    });

        //    return result;
        //}

        /// <summary>
        /// 新增或更新商户信息
        /// </summary>
        /// <returns></returns>
        //public async Task<ServiceResult> CreateMerchanAsync(MerchanCreateUpdateDto input)
        //{
        //    var result = new ServiceResult();

        //    var entity = await _merchanRepository.FindAsync(x => x.AppID.Equals(input.AppID));

        //    if (entity != null)
        //    {
        //        await _merchanRepository.DeleteAsync(x => x.AppID.Equals(input.AppID));
        //    }

        //    var merchan = ObjectMapper.Map<MerchanCreateUpdateDto, Merchan>(input);

        //    await _merchanRepository.InsertAsync(merchan);

        //    result.IsSuccess();

        //    return result;
        //}
    }
}