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
            var customers = new List<Tools.Model.Customers>();
            for (var i = 1; i <= 100; i++)
            {
                customers.Add(new Tools.Model.Customers
                {
                    name = "new customer" + i,
                    Age = 43 + i
                });
            }
            return Ok(customers);
        }
    }
}
