using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tools.models;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class yazeedController : ControllerBase
    {
        private readonly APIContext _context;

        public yazeedController(APIContext context)
        {
            _context = context;
        }

        // GET: api/yazeed
        [HttpGet]
        public async Task<ActionResult<IEnumerable<yazeed>>> Getyazeed()
        {
          if (_context.yazeed == null)
          {
              return NotFound();
          }
            return await _context.yazeed.ToListAsync();
        }

        // GET: api/yazeed/5
        [HttpGet("{id}")]
        public async Task<ActionResult<yazeed>> Getyazeed(int id)
        {
          if (_context.yazeed == null)
          {
              return NotFound();
          }
            var yazeed = await _context.yazeed.FindAsync(id);

            if (yazeed == null)
            {
                return NotFound();
            }

            return yazeed;
        }

        // PUT: api/yazeed/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putyazeed(int id, yazeed yazeed)
        {
            if (id != yazeed.Id)
            {
                return BadRequest();
            }

            _context.Entry(yazeed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!yazeedExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/yazeed
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<yazeed>> Postyazeed(yazeed yazeed)
        {
          if (_context.yazeed == null)
          {
              return Problem("Entity set 'APIContext.yazeed'  is null.");
          }
            _context.yazeed.Add(yazeed);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getyazeed", new { id = yazeed.Id }, yazeed);
        }

        // DELETE: api/yazeed/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteyazeed(int id)
        {
            if (_context.yazeed == null)
            {
                return NotFound();
            }
            var yazeed = await _context.yazeed.FindAsync(id);
            if (yazeed == null)
            {
                return NotFound();
            }

            _context.yazeed.Remove(yazeed);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool yazeedExists(int id)
        {
            return (_context.yazeed?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
