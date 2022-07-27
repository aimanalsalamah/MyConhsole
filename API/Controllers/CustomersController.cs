using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public ActionResult Get()
        {
            var Customers = new List<Tools.Model.Customers>();
            for (var i = 1; i <= 140; i++)
            {
                Customers.Add(new Tools.Model.Customers
                {
                    name = "Customers" + i,
                    Age = 42 + i
                });
            }
            return Ok (Customers);
        }
    }
}
