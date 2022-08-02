using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tools.models;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class YaseerController : ControllerBase
    {
        private readonly APIContext _context;

        public YaseerController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Yaseers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Yaseer>>> GetYaseer()
        {
          if (_context.Yaseer == null)
          {
              return NotFound();
          }
            return await _context.Yaseer.ToListAsync();
        }

        // GET: api/Yaseers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Yaseer>> GetYaseer(int id)
        {
          if (_context.Yaseer == null)
          {
              return NotFound();
          }
            var yaseer = await _context.Yaseer.FindAsync(id);

            if (yaseer == null)
            {
                return NotFound();
            }

            return yaseer;
        }

        // PUT: api/Yaseers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYaseer(int id, Yaseer yaseer)
        {
            if (id != yaseer.id)
            {
                return BadRequest();
            }

            _context.Entry(yaseer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YaseerExists(id))
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

        // POST: api/Yaseers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Yaseer>> PostYaseer(Yaseer yaseer)
        {
          if (_context.Yaseer == null)
          {
              return Problem("Entity set 'APIContext.Yaseer'  is null.");
          }
            _context.Yaseer.Add(yaseer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYaseer", new { id = yaseer.id }, yaseer);
        }

        // DELETE: api/Yaseers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYaseer(int id)
        {
            if (_context.Yaseer == null)
            {
                return NotFound();
            }
            var yaseer = await _context.Yaseer.FindAsync(id);
            if (yaseer == null)
            {
                return NotFound();
            }

            _context.Yaseer.Remove(yaseer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YaseerExists(int id)
        {
            return (_context.Yaseer?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
