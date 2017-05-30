using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LongTermCare.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LongTermCare.Controllers
{
    [Route("api/[controller]")]
    public class HomeApiController : Controller
    {
        private readonly DHADBContext db;
        public HomeApiController(DHADBContext context)
        {
            db = context;
        }
        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody]User LoginUser)
        {
            string UserId = LoginUser.id;
            string UserPwd = LoginUser.pwd;
            var ThisUser = db.UserInfo.Where(x=> x.userID==UserId && x.password==UserPwd).FirstOrDefault();
            var UR = new UserInfo();
            if (ThisUser!=null)
            {
                UR = ThisUser;
            }

            return Json(UR);
        }
    }
}
