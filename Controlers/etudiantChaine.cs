using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mime;

namespace WebApplication1.Controlers
{
    [Route("api/etudi")]
    [ApiController]
    [Produces(MediaTypeNames.Text.Plain)]
    public class etudiantChaine : ControllerBase
    {
        [HttpGet]
        public ActionResult<String> message()
        {
            return "hd";
        }
    }
}
