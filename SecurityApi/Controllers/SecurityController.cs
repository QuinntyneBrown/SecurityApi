using System.Web.Http;
using Common.Controllers;

namespace SecurityApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/security")]
    public class SecurityController : BaseApiController
    {
        public SecurityController()
        {

        }


        [HttpGet]
        [Route("tokenInfo")]
        public string Get()
        {
            return "test";
        }

    }
}
