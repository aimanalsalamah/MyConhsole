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

        [HttpGet("fillcustomr")]
        public ActionResult Fillcustomr()
        {
            for (int i = 1; i < 100; i++)
            {
                _context.Customr.Add(new()
                {
                    name = "customr " + i,
                    Age = i
                });
            }
            _context.SaveChanges();
            return Ok("Customers inserted.");
        }

        [HttpGet("fillrecord")]
        public ActionResult Fillrecord()
        {
            for (int i = 0; i < 30; i ++) 
            {
                _context.record1.Add(new()
                {
                    name = "Record " + i,
                    Age = i
                });
            }
            _context.SaveChanges();
            return Ok("Record inserted.");
        } 
        
        [HttpGet("fillFollowing")]
        public ActionResult FillFollowing()
        {
            for (int i = 1; i < 40; i++)
            {
                _context.Following.Add(new()
                {
                    name = "Followings " + i,
                    Age = i
                });
            }
            _context.SaveChanges();
            return Ok("Followings inserted.");
        }
    }
    }