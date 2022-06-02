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
    public class MidlesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public MidlesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Midles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Midle>>> GetMidles()
        {
          if (_context.Midles == null)
          {
              return NotFound();
          }
            return await _context.Midles.ToListAsync();
        }

        // GET: api/Midles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Midle>> GetMidle(long id)
        {
          if (_context.Midles == null)
          {
              return NotFound();
          }
            var midle = await _context.Midles.FindAsync(id);

            if (midle == null)
            {
                return NotFound();
            }

            return midle;
        }

        // PUT: api/Midles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMidle(long id, Midle midle)
        {
            if (id != midle.Id)
            {
                return BadRequest();
            }

            _context.Entry(midle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MidleExists(id))
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

        // POST: api/Midles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Midle>> PostMidle(Midle midle)
        {
          if (_context.Midles == null)
          {
              return Problem("Entity set 'ApplicationContext.Midles'  is null.");
          }
            _context.Midles.Add(midle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMidle", new { id = midle.Id }, midle);
        }

        // DELETE: api/Midles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMidle(long id)
        {
            if (_context.Midles == null)
            {
                return NotFound();
            }
            var midle = await _context.Midles.FindAsync(id);
            if (midle == null)
            {
                return NotFound();
            }

            _context.Midles.Remove(midle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MidleExists(long id)
        {
            return (_context.Midles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
