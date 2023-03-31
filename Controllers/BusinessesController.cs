using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessApi.Models;
using Newtonsoft.Json;

namespace BusinessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
        private readonly BusinessApiContext _context;

        public BusinessesController(BusinessApiContext context)
        {
            _context = context;
        }

        [Route("api/tryjson")]
        [HttpGet]
        public ActionResult<IEnumerable<Business>> Get(int pageNumber = 1, int resultsPerPage = 2)
        {
            var query = _context.Businesses.OrderBy(x => x.BusinessId);
            var totalResultCount = query.Count();
            var items = query.Skip((pageNumber - 1) * resultsPerPage).Take(resultsPerPage).ToList();
            var totalPages = (int)Math.Ceiling((double)totalResultCount / resultsPerPage);
            var metadata = new
            {
                totalResultCount,
                resultsPerPage,
                currentPage = pageNumber,
                totalPages
            };
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            return items.ToList();
        }


        // GET: api/Animals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> Get( string species, string name, int minimumAge) 
        {
            IQueryable<Business> query = _context.Businesses.AsQueryable();
            if ( species != null)
            {
                query = query.Where(entry => entry.Species == species);
            }
            if ( name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (minimumAge > 0)
            {
                query =  query.Where(entry => entry.Age >= minimumAge);
            }
            return await query.ToListAsync();
        }
 
        [HttpGet("{id}")]
        public async Task<ActionResult<Business>> GetBusiness(int id)
        {
            var business = await _context.Businesses.FindAsync(id);

            if (business == null)
            {
                return NotFound();
            }

            return business;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusiness(int id, Business business)
        {
            if (id != business.BusinessId)
            {
                return BadRequest();
            }

            _context.Entry(business).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Business>> PostBusiness(Business business)
        {
            _context.Businesses.Add(business);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusiness", new { id = business.BusinessId }, business);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusiness(int id)
        {
            var business = await _context.Businesses.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }

            _context.Businesses.Remove(business);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusinessExists(int id)
        {
            return _context.Businesses.Any(e => e.BusinessId == id);
        }
    }
}
