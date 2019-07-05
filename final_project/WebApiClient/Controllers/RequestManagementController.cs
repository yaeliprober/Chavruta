using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using DTO;

namespace WebApiClient.Controllers
{
    [EnableCors("*", "*", "*")]
    public class RequestManagementController : ApiController
    {
        RequestLogic bll = new RequestLogic();

        [System.Web.Http.HttpPost]
        public RequestResult AddRequest(RequestParameterDTO req)
        {
            return bll.AddRequest(req);
        }
    }
}
