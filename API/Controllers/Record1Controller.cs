using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tools.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Record1Controller : ControllerBase
    {
        private readonly APIContext _context;

        public Record1Controller(APIContext context)
        {
            _context = context;
        }

        // GET: api/Record1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<record1>>> Getrecord1()
        {
          if (_context.Record == null)
          {
              return NotFound();
          }

            List<Tools.Model.record1> Record = await _context.Record.ToListAsync();
            return Record;
        }

        // GET: api/Record1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<record1>> Getrecord1(int id)
        {
          if (_context.Record == null)
          {
              return NotFound();
          }
            var record1 = await _context.Record.FindAsync(id);

            if (record1 == null)
            {
                return NotFound();
            }

            return record1;
        }

        // PUT: api/Record1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putrecord1(int id, record1 record1)
        {
            if (id != record1.id)
            {
                return BadRequest();
            }

            _context.Entry(record1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!record1Exists(id))
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

        // POST: api/Record1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<record1>> Postrecord1(record1 record1)
        {
          if (_context.Record == null)
          {
              return Problem("Entity set 'APIContext.record1'  is null.");
          }
            _context.Record.Add(record1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getrecord1", new { id = record1.id }, record1);
        }

        // DELETE: api/Record1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleterecord1(int id)
        {
            if (_context.Record == null)
            {
                return NotFound();
            }
            var record1 = await _context.Record.FindAsync(id);
            if (record1 == null)
            {
                return NotFound();
            }

            _context.Record.Remove(record1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool record1Exists(int id)
        {
            return (_context.Record?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
