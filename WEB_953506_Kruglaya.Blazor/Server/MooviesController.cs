using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB_953506_Kruglaya.Blazor.Client.Models;
using WEB_953506_Kruglaya.Data;
using WEB_953506_Kruglaya.Entities;

namespace WEB_953506_Kruglaya.Blazor.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class MooviesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MooviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Moovies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListViewModel>>> GetMoovies(int? categories)
        {
            var moovies = _context.Moovies.Where(
                d => !categories.HasValue || d.CategoryID == categories.Value)
                .Select(m=> new ListViewModel() { MoovieId=m.ID, MoovieName=m.Name});
            return await moovies.ToListAsync();
        }

        // GET: api/Moovies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsViewModel>> GetMoovie(int id)
        {
            var moovie = await _context.Moovies.FindAsync(id);

            if (moovie == null)
            {
                return NotFound();
            }

            return new DetailsViewModel() { MoovieName=moovie.Name, Description=moovie.Description, Image=moovie.Image, Time=moovie.Time };
        }

        // PUT: api/Moovies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMoovie(int id, Moovie moovie)
        {
            if (id != moovie.ID)
            {
                return BadRequest();
            }

            _context.Entry(moovie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoovieExists(id))
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

        // POST: api/Moovies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Moovie>> PostMoovie(Moovie moovie)
        {
            _context.Moovies.Add(moovie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMoovie", new { id = moovie.ID }, moovie);
        }

        // DELETE: api/Moovies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoovie(int id)
        {
            var moovie = await _context.Moovies.FindAsync(id);
            if (moovie == null)
            {
                return NotFound();
            }

            _context.Moovies.Remove(moovie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MoovieExists(int id)
        {
            return _context.Moovies.Any(e => e.ID == id);
        }
    }
}
