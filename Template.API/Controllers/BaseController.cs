using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Template.MODEL.Common;

namespace Template.API.Controllers
{
    public class BaseController : ApiController
    {
        public readonly ResultInfo _resultInfo;
        public BaseController()
        {
            _resultInfo = new ResultInfo();
        }
    }
}
