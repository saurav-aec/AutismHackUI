using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using AutismHackScenario3.Models;

namespace AutismHackScenario3.Controllers
{
    public class MeController : ApiController
    {


        public MeController()
        {
        }

        // GET api/Me
        public GetViewModel Get()
        {
            return new GetViewModel() { Hometown = "" };
        }
    }
}