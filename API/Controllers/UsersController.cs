using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public ActionResult Get()
        {
            var users = new List<Tools.Model.Users>();
            for (var i = 1; i <= 100; i++)
            {
                users.Add(new Tools.Model.Users
                {
                    name = "new user" + i,
                    Age = 43 + i
                });
            }
            return Ok(users);
        }

        [HttpPost]
        public ActionResult Post(Tools.Model.Users user)
        {
            return Ok();
        }
    }
}
