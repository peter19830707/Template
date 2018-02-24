using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template.Practice.Filter
{
    public class AuthorizePlusAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("https://......");//未登入連結到登入入口
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //驗證方式 session 或者 FormsAuthentication
            bool flag = true;
            if (flag) //驗證是否登入 
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}