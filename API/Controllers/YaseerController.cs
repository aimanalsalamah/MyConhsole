using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class YaseerController : ControllerBase
    {
        public ActionResult Get()
        {
            var Yaseer = new List<Tools.models.Yaseer>();
            for (var i = 1; i <= 100; i++)
            {
                Yaseer.Add(new Tools.models.Yaseer
                {
                    name = "new Yaseer" + i,
                    age = 29 + i
                });
            }
            return Ok (Yaseer);
        }
    }
}
