using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using AutismHackScenario3.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using AutismHackScenario3.Common;

namespace AutismHackScenario3.Controllers
{

    public class MeController : ApiController
    {
        Helper _helper = new Helper();  

        public MeController()
        {
        }

        // GET api/Me
        public GetViewModel Get()
        {
            return new GetViewModel() { Hometown = "" };
        }

        [Route("api/GetScore")]
        public GetViewModel GetScore()
        {

            _helper.InvokeRequestResponseService().Wait();
            return new GetViewModel() { Hometown = "" };
        }


    }
}
