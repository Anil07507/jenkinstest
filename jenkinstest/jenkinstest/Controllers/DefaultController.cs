using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace jenkinstest.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("test/test")]
        public IHttpActionResult Test()
        {
            return Ok(new { test = "Ok" });
        }
    }

}
