using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tools.Model;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FollowingsController : ControllerBase
    {
        private readonly APIContext _context;

        public FollowingsController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Followings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Following>>> GetFollowing()
        {
          if (_context.Following == null)
          {
              return NotFound();
          }
            return await _context.Following.ToListAsync();
        }

        // GET: api/Followings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Following>> GetFollowing(int id)
        {
          if (_context.Following == null)
          {
              return NotFound();
          }
            var following = await _context.Following.FindAsync(id);

            if (following == null)
            {
                return NotFound();
            }

            return following;
        }

        // PUT: api/Followings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFollowing(int id, Following following)
        {
            if (id != following.id)
            {
                return BadRequest();
            }

            _context.Entry(following).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FollowingExists(id))
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

        // POST: api/Followings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Following>> PostFollowing(Following following)
        {
          if (_context.Following == null)
          {
              return Problem("Entity set 'APIContext.Following'  is null.");
          }
            _context.Following.Add(following);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFollowing", new { id = following.id }, following);
        }

        // DELETE: api/Followings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFollowing(int id)
        {
            if (_context.Following == null)
            {
                return NotFound();
            }
            var following = await _context.Following.FindAsync(id);
            if (following == null)
            {
                return NotFound();
            }

            _context.Following.Remove(following);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FollowingExists(int id)
        {
            return (_context.Following?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
