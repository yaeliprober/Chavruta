using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using DTO;
//using System.Diagnostics;

namespace WebApiClient.Controllers
{
    [EnableCors("*", "*", "*")]
  [RoutePrefix("api/UsersManagement")]
    public class UsersManagementController : ApiController
    {
        UserLogic bll = new UserLogic();
        // GET api/values
        [Route("CheckPass")]
        [HttpPost]
        public RequestResult CheckPass(UserDTO u)
        {
            //using (EventLog el = new EventLog()) {   
            //    el.WriteEntry("YAEL....RIVKY...", EventLogEntryType.SuccessAudit);
            //}            
            return bll.CheckPass(u.userMail, u.userPassword);
        }

        [Route("ForgotPass/{email}")]
        [HttpGet]
        public RequestResult ForgotPass(string email)
        {
            return bll.ForgotPass(email);
          
        }
        //[HttpPost]
        //public RequestResult AddUser(UserDTO u)
        //{
        //    return bll.AddUser(u);
        //}
        //[System.Web.Http.HttpPost]
        //public RequestResult UpdateUser(UserDTO u)
        //{
        //    return bll.UpdateUser(u);
        //}
        ////public RequestResult GetAllUsers()
        ////{
        ////    return new RequestResult() { Data = new List<UserDTO>() { new UserDTO() { userName = "sdf", userId = 1 }, new UserDTO() { userName = "ssdfdsfdf", userId = 1 } }, Message = "all good", Status = true };
        ////}
    }
}
