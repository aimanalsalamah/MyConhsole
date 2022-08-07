using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tools.Models;

namespace API.controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly APIContext _context;

        public StudentsController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Students>>> GetStudents()
        {
            if (_context.Students == null)
            {
                return NotFound();
            }
            return await _context.Students.ToListAsync();
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Students>> GetStudents(int id)
        {
            if (_context.Students == null)
            {
                return NotFound();
            }
            var Students = await _context.Students.FindAsync(id);

            if (Students == null)
            {
                return NotFound();
            }

            return Students;
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudents(int id, Students Students)
        {
            if (id != Students.Id)
            {
                return BadRequest();
            }

            _context.Entry(Students).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentsExists(id))
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

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Students>> PostCustomers(Students students)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'APIContext.Students'  is null.");
            }
            _context.Students.Add(Students);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudents", new { id = Students.Id }, Students);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudents(int id)
        {
            if (_context.Students == null)
            {
                return NotFound();
            }
            var Students = await _context.Students.FindAsync(id);
            if (Students == null)
            {
                return NotFound();
            }

            _context.Students.Remove(Students);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentsExists(int id)
        {
            return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
