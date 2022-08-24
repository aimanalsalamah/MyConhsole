using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tools.Model;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomrsController : ControllerBase
    {
        private readonly APIContext _context;

        public CustomrsController(APIContext context)
        {
            _context = context;
        }

        // GET: api/customrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customr>>> Getcustomr()
        {
            if (_context.Customr == null)
            {
                return NotFound();
            }
            return await _context.Customr.ToListAsync();
        }

        // GET: api/customrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customr>> Getcustomr(int id)
        {
            if (_context.Customr == null)
            {
                return NotFound();
            }
            var customr = await _context.Customr.FindAsync(id);

            if (customr == null)
            {
                return NotFound();
            }

            return customr;
        }

        // PUT: api/customrs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcustomr(int id, Customr customr)
        {
            if (id != customr.id)
            {
                return BadRequest();
            }

            _context.Entry(customr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!customrExists(id))
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

        // POST: api/customrs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customr>> Postcustomr(Customr customr)
        {
            if (_context.Customr == null)
            {
                return Problem("Entity set 'APIContext.customr'  is null.");
            }
            _context.Customr.Add(customr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcustomr", new { id = customr.id }, customr);
        }
        
        // DELETE: api/customrs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletecustomr(int id)
        {
            if (_context.Customr == null)
            {
                return NotFound();
            }
            var customr = await _context.Customr.FindAsync(id);
            if (customr == null)
            {
                return NotFound();
            }

            _context.Customr.Remove(customr);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool customrExists(int id)
        {
            return (_context.Customr?.Any(e => e.id == id)).GetValueOrDefault();
        }

    }
}
