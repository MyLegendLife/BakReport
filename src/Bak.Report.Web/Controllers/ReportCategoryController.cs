using Bak.Report.Application.Contracts.Reports;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bak.Report.Web.Controllers
{
    [Route("Report/Category")]
    public class ReportCategoryController : Controller
    {
        private readonly IReportCategoryService _reportCategoryService;

        public ReportCategoryController(IReportCategoryService reportCategoryService)
        {
            _reportCategoryService = reportCategoryService;
        }

        [HttpGet]
        [Route("List")]
        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        [Route("List")]
        public async Task<IActionResult> List(int page, int limit)
        {
            var result = await _reportCategoryService.GetListAsync();

            return Json(result);
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] ReportCategoryDto input)
        {
            var result = await _reportCategoryService.CreateAsync(input);

            return Json(result);
        }

        [HttpGet]
        [Route("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _reportCategoryService.GetAsync(id);

            return View(result.Result);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit([FromBody] ReportCategoryDto input)
        {
            var result = await _reportCategoryService.UpdateAsync(input);

            return Json(result);
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _reportCategoryService.DeleteAsync(id);

            return Json(result);
        }
    }
}
