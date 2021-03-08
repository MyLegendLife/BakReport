using log4net;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Bak.Report.Web.Filters
{
    public class ReportExceptionFilter : IExceptionFilter
    {
        private readonly ILog _log;
        public ReportExceptionFilter()
        {
            _log = LogManager.GetLogger(typeof(ReportExceptionFilter)); ;
        }

        /// <summary>
        /// 异常处理
        /// </summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            // 错误日志记录
            _log.Error($"{context.HttpContext.Request.Path}|{context.Exception.Message}", context.Exception);
        }
    }
}
