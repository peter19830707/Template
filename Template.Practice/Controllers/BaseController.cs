using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Template.MODEL.Common;
using Template.Practice.Helper;

namespace Template.Practice.Controllers
{
    public class BaseController : Controller
    {
        private readonly ApiHelper api;
        public SendInfo Send { get; private set; }
        public UserInfo UserInfo;
        public BaseController()
        {
            api = new ApiHelper();
        }
        /// <summary>
        /// ApiPost資料處理
        /// </summary>
        /// <typeparam name="TR"></typeparam>
        /// <typeparam name="TS"></typeparam>
        /// <param name="Data"></param>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public TR ApiPost<TR, TS>(TS Data, string strUrl)
        {
            return Task.Run(() => api.Post<TR, TS>(strUrl, Data)).Result;
        }
        /// <summary>
        /// ApiGet資料處理
        /// </summary>
        /// <typeparam name="TR"></typeparam>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public TR ApiGett<TR>(string strUrl)
        {
            return Task.Run(() => api.Get<TR>(strUrl)).Result;
        }
        /// <summary>
        /// 進入Action
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //進入action前處理使用者資料
        }
        /// <summary>
        /// 紀錄Action結束後處理的方法
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //log nlog log4net sql
        }
    }
}