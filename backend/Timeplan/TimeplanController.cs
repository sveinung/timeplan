using Microsoft.AspNetCore.Mvc;

namespace Timeplan.Timeplan
{
    [Route("timeplan")]
    [ApiController]
    public class TimeplanController : ControllerBase
    {
        [HttpGet]
        public string HentTimeplan()
        {
            return "Timeplan";
        }
    }
}