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
    public class SearchThanksCardToController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public SearchThanksCardToController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<ThanksCard>>> Post([FromBody] SearchThanksCard searchThanksCard)
        {
            return await _context.ThanksCards
                .Include(ThanksCard => ThanksCard.To)
                .Where(s => s.To.Name.Contains(searchThanksCard.SearchWord2)).ToListAsync();

        }
    }
}