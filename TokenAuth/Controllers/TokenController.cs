using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TokenAuth.Business_Layer;
using TokenAuth.Models;

namespace TokenAuth.Controllers
{
    public class TokenController : ApiController
    {
        [Authorize]
        [HttpGet]
        public IHttpActionResult Authorize()
        {
            return Ok("hey u authorized");
        }

        //[Authorize]
        [HttpPost]
        public IHttpActionResult RegisterUser(User userModel)
        {
            using (UserBusinessLayer userbl = new UserBusinessLayer())
            {
                var response = userbl.RegisterUser(userModel);
            }

            return Ok("User Registerd Successfully");
        }

    }
}
