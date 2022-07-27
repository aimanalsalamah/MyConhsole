using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public ActionResult Get()
        {
            var user = new List<Tools.Model.User>();
            for (var i = 1; i <= 100; i++)
            {
                user.Add(new Tools.Model.User
                {
                    name = "new user" + i,
                    Age = 43 + i
                });
            }
            return Ok(user);
        }

        [HttpPost]
        public ActionResult Post(Tools.Model.User user)
        {
            return Ok();
        }
    }
}
