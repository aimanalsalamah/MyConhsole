using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        public ActionResult Get()
        {
            var employers = new List<Tools.Models.Employers>();
            for (var i = 1; i <= 100; i++)
            {
                employers.Add(new Tools.Models.Employers
                {
                    name = "new Employers" + i,
                    Age = 43 + i
                });
            }
            return Ok(employers);
        }
    }
}
