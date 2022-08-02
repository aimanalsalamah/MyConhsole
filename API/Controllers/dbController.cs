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

        [HttpGet("fillYaseer")]
        public ActionResult FillYaseer()
        {
            for (int i = 1; i < 100; i++)
            {
                _context.Yaseer.Add(new()
                {
                    name = "Yaseer " + i,
                    age = i
                });
            }
            _context.SaveChanges();
            return Ok("Yaseer inserted.");
        }

        [HttpGet("fillyazeed")]
        public ActionResult Fillyazeed()
        {
            for (int i = 1; i < 100; i++)
            {
                _context.yazeed.Add(new()
                {
                    name = "yazeed " + i,
                    age = i
                });
            }
            _context.SaveChanges();
            return Ok("yazeed inserted.");
        }
    }
}