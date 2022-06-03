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
    public class ThanksCardsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ThanksCardsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThanksCard>>> GetThanksCards()
        {
          if (_context.ThanksCards == null)
          {
              return NotFound();
          }
            return await _context.ThanksCards.ToListAsync();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThanksCard>> GetThanksCard(long id)
        {
          if (_context.ThanksCards == null)
          {
              return NotFound();
          }
            var thanksCard = await _context.ThanksCards.FindAsync(id);

            if (thanksCard == null)
            {
                return NotFound();
            }

            return thanksCard;
        }

        // PUT: api/ThanksCards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThanksCard(long id, ThanksCard thanksCard)
        {
            if (id != thanksCard.Id)
            {
                return BadRequest();
            }

            _context.Entry(thanksCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThanksCardExists(id))
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

        // POST: api/ThanksCards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ThanksCard>> PostThanksCard(ThanksCard thanksCard)
        {
          if (_context.ThanksCards == null)
          {
              return Problem("Entity set 'ApplicationContext.ThanksCards'  is null.");
          }
            _context.ThanksCards.Add(thanksCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThanksCard", new { id = thanksCard.Id }, thanksCard);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThanksCard(long id)
        {
            if (_context.ThanksCards == null)
            {
                return NotFound();
            }
            var thanksCard = await _context.ThanksCards.FindAsync(id);
            if (thanksCard == null)
            {
                return NotFound();
            }

            _context.ThanksCards.Remove(thanksCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThanksCardExists(long id)
        {
            return (_context.ThanksCards?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
