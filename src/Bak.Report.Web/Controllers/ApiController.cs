using Bak.Report.Application.Contracts.Reports;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bak.Report.Web.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly IReportCategoryService _reportCategoryService;
        private readonly IReportInfoService _reportInfoService;
        private readonly IReportImageService _reportImageService;

        public ApiController(IReportInfoService reportInfoService,  IReportCategoryService reportCategoryService, IReportImageService reportImageService)
        {
            _reportInfoService = reportInfoService;
            _reportCategoryService = reportCategoryService;
            _reportImageService = reportImageService;
        }

        [HttpPost]
        [Route("GetList")]
        public async Task<IActionResult> GetList(int categoryId = -1)
        {
            var result = await _reportInfoService.GetListAsync();

            return Json(result);
        }

        [HttpPost]
        [Route("Get")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _reportInfoService.GetAsync(id);

            var requestUrl = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.PathBase;

            foreach (var image in result.Result.Images)
            {
                image.Uri = requestUrl + image.Uri;
            }

            return Json(result.Result);
        }
    }
}
