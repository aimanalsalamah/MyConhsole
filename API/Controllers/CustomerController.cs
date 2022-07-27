using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public ActionResult Get()
        {
            var customer = new List<Tools.Model.Customer>();
            for (var i = 1; i <= 100; i++)
            {
                customer.Add(new Tools.Model.Customer
                {
                    name = "new customer" + i,
                    Age = 43 + i
                });
            }
            return Ok(customer);
        }
    }
}