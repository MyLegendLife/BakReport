using Bak.Report.Application.Contracts.Reports;
using Bak.Report.Common.Base;
using Bak.Report.Common.Base.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Bak.Report.Web.Controllers
{
    [Route("Report/Info")]
    public class ReportInfoController : Controller
    {
        private readonly IReportCategoryService _reportCategoryService;
        private readonly IReportInfoService _reportInfoService;
        private readonly IReportImageService _reportImageService;
        private readonly IHostEnvironment _hostEnvironment;

        public ReportInfoController(IReportInfoService reportInfoService, IHostEnvironment hostEnvironment, IReportCategoryService reportCategoryService, IReportImageService reportImageService)
        {
            _reportInfoService = reportInfoService;
            _hostEnvironment = hostEnvironment;
            _reportCategoryService = reportCategoryService;
            _reportImageService = reportImageService;
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
            //var input = new PagedAndSortedResultRequestDto()
            //{
            //    SkipCount = page - 1,
            //    MaxResultCount = limit,
            //    Sorting = "CreationTime DESC"
            //};

            var result = await _reportInfoService.GetListAsync();

            return Json(result);
        }

        [HttpGet]
        [Route("Add")]
        public async Task<IActionResult> Add()
        {
            var categorys = await _reportCategoryService.GetListAsync();

            ViewData["Category"] = new SelectList(categorys.Result, "Id", "Name");

            return View();
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] ReportCreateUpdateInput input)
        {
            var result = await _reportInfoService.CreateAsync(input);

            return Json(result);
        }

        [HttpGet]
        [Route("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _reportInfoService.GetAsync(id);

            var categorys = await _reportCategoryService.GetListAsync();

            ViewData["Category"] = new SelectList(categorys.Result, "Id", "Name", result.Result.CategoryId);

            return View(result.Result);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit([FromBody] ReportCreateUpdateInput input)
        {
            //删除图片
            await _reportImageService.DeleteAsync(input.Id);

            var result = await _reportInfoService.UpdateAsync(input);

            return Json(result);
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            //删除图片


            var result = await _reportInfoService.DeleteAsync(id);

            return Json(result);
        }

        [HttpPost]
        [Route("UploadDoc")]
        public async Task<IActionResult> UploadDoc(IFormFile file)
        {
            var result = new ServiceResult();

            //文件后缀
            var suffix = file.FileName.Substring(file.FileName.LastIndexOf('.'));

            //文件相对路径
            var uri = @"/files/docs/" + "文档" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 10000) + suffix;

            //文件绝对路径
            var path = _hostEnvironment.ContentRootPath + uri;

            await using var fs = System.IO.File.Create(path);
            await file.CopyToAsync(fs);//将上载文件的内容复制到目标流
            await fs.FlushAsync();//清除此流的缓冲区并导致将任何缓冲数据写入

            result.IsSuccess("../.." + uri);

            return Json(result);
        }

        [HttpPost]
        [Route("UploadImage")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            var result = new ServiceResult();

            //文件后缀
            var suffix = file.FileName.Substring(file.FileName.LastIndexOf('.'));

            //文件相对路径
            var uri = @"/files/images/" + "图片" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(1000, 10000) + suffix;

            //文件绝对路径
            var path = _hostEnvironment.ContentRootPath + uri;


            await using var fs = System.IO.File.Create(path);
            await file.CopyToAsync(fs);//将上载文件的内容复制到目标流
            await fs.FlushAsync();//清除此流的缓冲区并导致将任何缓冲数据写入

            result.IsSuccess("../.." + uri);

            return Json(result);
        }
    }
}
