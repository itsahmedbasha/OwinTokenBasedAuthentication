using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
    }
}
