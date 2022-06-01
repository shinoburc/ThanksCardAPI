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
    public class TitlesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TitlesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Titles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Title>>> GetTitles()
        {
          if (_context.Titles == null)
          {
              return NotFound();
          }
            return await _context.Titles.ToListAsync();
        }

        // GET: api/Titles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Title>> GetTitle(long id)
        {
          if (_context.Titles == null)
          {
              return NotFound();
          }
            var title = await _context.Titles.FindAsync(id);

            if (title == null)
            {
                return NotFound();
            }

            return title;
        }

        // PUT: api/Titles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTitle(long id, Title title)
        {
            if (id != title.Id)
            {
                return BadRequest();
            }

            _context.Entry(title).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TitleExists(id))
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

        // POST: api/Titles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Title>> PostTitle(Title title)
        {
          if (_context.Titles == null)
          {
              return Problem("Entity set 'ApplicationContext.Titles'  is null.");
          }
            _context.Titles.Add(title);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTitle", new { id = title.Id }, title);
        }

        // DELETE: api/Titles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTitle(long id)
        {
            if (_context.Titles == null)
            {
                return NotFound();
            }
            var title = await _context.Titles.FindAsync(id);
            if (title == null)
            {
                return NotFound();
            }

            _context.Titles.Remove(title);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TitleExists(long id)
        {
            return (_context.Titles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
