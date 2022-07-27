
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public ActionResult Get()
        {
          return Ok("ok from Customers controller");

        }

      }
 }
