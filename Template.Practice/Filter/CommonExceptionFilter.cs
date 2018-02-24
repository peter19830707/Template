using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template.Practice.Filter
{
    public class CommonExceptionFilter : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //驗證出現錯誤訊息紀錄 處理
            Elmah.ErrorSignal.FromCurrentContext().Raise(filterContext.Exception);
        }
    }
}