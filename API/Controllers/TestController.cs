using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        public ActionResult Get()
        {
            return Ok("Ok form controller");
        }
         
    }
}
