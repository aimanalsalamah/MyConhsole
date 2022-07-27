using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class YazeedController : ControllerBase
    {
        public ActionResult Get()
        {
            var Yazeed = new List<Tools.models.yazeed>();
            for (var i = 1; i <= 100; i++)
            {
                Yazeed.Add(new Tools.models.yazeed
                {
                    name = " new Yazeed" + i,
                    age = 29 + i
                });
            }
            return Ok(Yazeed);
        }
    }
}
