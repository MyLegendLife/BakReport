using Microsoft.AspNetCore.Mvc.Filters;
using System;
using log4net;

namespace Bak.Report.HttpApi.Host.Filters
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
