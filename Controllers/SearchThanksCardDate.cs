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
    public class SearchThanksCardDateController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public SearchThanksCardDateController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<ThanksCard>>> Post([FromBody] SearchThanksCard searchThanksCard)
        {
            return await _context.ThanksCards
                .Where( c => c.Date.Year.Equals(searchThanksCard.SearchDate) || c.Date.Month.Equals(searchThanksCard.SearchDate) || c.Date.Day.Equals(searchThanksCard.SearchDate)).ToListAsync();
        }
    }
}
