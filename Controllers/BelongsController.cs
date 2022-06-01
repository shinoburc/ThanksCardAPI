using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThanksCardServer2.Models;

namespace ThanksCardServer2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BelongsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public BelongsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Belongs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Belong>>> GetBelongs()
        {
          if (_context.Belongs == null)
          {
              return NotFound();
          }
            return await _context.Belongs.ToListAsync();
        }

        // GET: api/Belongs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Belong>> GetBelong(long id)
        {
          if (_context.Belongs == null)
          {
              return NotFound();
          }
            var belong = await _context.Belongs.FindAsync(id);

            if (belong == null)
            {
                return NotFound();
            }

            return belong;
        }

        // PUT: api/Belongs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBelong(long id, Belong belong)
        {
            if (id != belong.Id)
            {
                return BadRequest();
            }

            _context.Entry(belong).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BelongExists(id))
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

        // POST: api/Belongs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Belong>> PostBelong(Belong belong)
        {
          if (_context.Belongs == null)
          {
              return Problem("Entity set 'ApplicationContext.Belongs'  is null.");
          }
            _context.Belongs.Add(belong);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBelong", new { id = belong.Id }, belong);
        }

        // DELETE: api/Belongs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBelong(long id)
        {
            if (_context.Belongs == null)
            {
                return NotFound();
            }
            var belong = await _context.Belongs.FindAsync(id);
            if (belong == null)
            {
                return NotFound();
            }

            _context.Belongs.Remove(belong);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BelongExists(long id)
        {
            return (_context.Belongs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
