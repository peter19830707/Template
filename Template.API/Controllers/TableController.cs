using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Template.BLL;
using Template.MODEL.Common;
using Template.MODEL.Enum;
using Template.MODEL.Template;

namespace Template.API.Controllers
{
    public class TableController : BaseController
    {
        private readonly TableBLL tableBLL;
        public TableController()
        {
            tableBLL = new TableBLL();
        }
        /// <summary>
        /// 新增一筆資料
        /// </summary>
        /// <param name="Para"></param>
        /// <returns></returns>
        [ResponseType(typeof(ResultInfo))]
        [ApiExplorerSettings(IgnoreApi = false)]
        [HttpPost]
        public IHttpActionResult Create(SendInfo<CreateTableIn> Para)
        {
            var _rc = ReturnCode.CreateSuccess;
            try
            {
                tableBLL.Create(Para.Data, Para.MemId);
            }
            catch (CommonException e)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(e);
                _rc = ReturnCode.CreateFail;
            }
            return Json(_resultInfo.NonResult(_rc));
        }
    }
}
