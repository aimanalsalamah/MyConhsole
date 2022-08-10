using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DbController : ControllerBase
    {
        private readonly APIContext _context;

        public DbController(APIContext context)
        {
            _context = context;
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return Ok(_context.Database.EnsureCreated());
        }

        [HttpGet("delete")]
        public ActionResult Delete()
        {
            return Ok(_context.Database.EnsureDeleted());
        }

        [HttpGet("fillCustomers")]
        public ActionResult FillCustomers()
        {
            for (int i = 1; i < 100; i++)
            {
                _context.Customers.Add(new()
                {
                    Name = "Customer " + i,
                    Age = i
                });
            }
            _context.SaveChanges();
            return Ok("Customers inserted.");
        }

        [HttpGet("fillUsers")]
        public ActionResult FillEmployers()
        {
            for (int i = 1; i < 100; i++)
            {
                _context.Users.Add(new()
                {
                    Name = "Users " + i,
                    Age = i
                });
            }
            _context.SaveChanges();
            return Ok("Stuents inserted.");
            }
            [HttpGet("fillStudents")]
            public ActionResult FillStudents()
            {
                for (int i = 1; i < 100; i++)
                {
                    _context.Student.Add(new()
                    {
                        Name = "student " + i,
                        Age = i
                    });
                }
                _context.SaveChanges();
                return Ok("Students inserted.");
            
        }
    }
}
    