﻿using Bak.Report.Domain.Base;
using Bak.Report.Domain.Base.Repositories;
using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.Base
{
    public class ThirdAccessTokenRepository : EfCoreRepository<ReportDbContext, ThirdAccessToken>, IThirdAccessTokenRepository
    {                                                                                                    
        public ThirdAccessTokenRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// 获取令牌
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAccessTokenAsync()
        {
            var entity = await DbContext.Set<ThirdAccessToken>().FirstOrDefaultAsync();

            if (entity == null)
                return "";

            return DateTime.Now > entity.ValidDate.AddMinutes(-10) ? "" : entity.AccessToken;
        }

        /// <summary>
        /// 更新密钥
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="expiresIn"></param>
        /// <returns></returns>
        public async Task UpdateAccessTokenAsync(string accessToken, int expiresIn)
        {
            var entity = await DbContext.Set<ThirdAccessToken>().FirstOrDefaultAsync();

            if (entity == null)
                return;

            entity.AccessToken = accessToken;
            entity.ValidDate = DateTime.Now.AddSeconds(expiresIn);

            DbContext.Update(entity);
        }
    }
}