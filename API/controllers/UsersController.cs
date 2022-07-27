using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public ActionResult Get()
        {
            var users = new List<Tools.Models.Users>();
            for (var i = 1; i <= 100; i++)
            {
                users.Add(new Tools.Models.Users
                {
                    Name = "new user" + i,
                    Age = 43 + i
                });
            }
            return Ok(users);
        }

        [HttpPost]
        public ActionResult Post(Tools.Models.Users user)
        {
            return Ok();
        }
    }
}