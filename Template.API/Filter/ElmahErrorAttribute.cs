using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using Template.MODEL.Enum;
using Template.MODEL.Common;
using System.Net.Http;

namespace Template.API.Filter
{
    public class ElmahErrorAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception != null)
                Elmah.ErrorSignal.FromCurrentContext().Raise(actionExecutedContext.Exception);

            base.OnException(actionExecutedContext);
            ResultInfo ResultInfo = new ResultInfo()
            {
                RC = (int)ReturnCode.Exception,
                RM = "伺服器異常錯誤．"
            };
            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(ResultInfo);
        }
    }
}