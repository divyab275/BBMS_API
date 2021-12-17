using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BBMS_API.Models;

namespace BBMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodCampsController : ControllerBase
    {
        private readonly ProvidenceDbContext _context;

        public BloodCampsController(ProvidenceDbContext context)
        {
            _context = context;
        }

        // GET: api/BloodCamps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BloodCamp>>> GetBloodCamps()
        {
            return await _context.BloodCamps.ToListAsync();
        }

        // GET: api/BloodCamps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BloodCamp>> GetBloodCamp(int id)
        {
            var bloodCamp = await _context.BloodCamps.FindAsync(id);

            if (bloodCamp == null)
            {
                return NotFound();
            }

            return bloodCamp;
        }

        // PUT: api/BloodCamps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloodCamp(int id, BloodCamp bloodCamp)
        {
            if (id != bloodCamp.ID)
            {
                return BadRequest();
            }

            _context.Entry(bloodCamp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodCampExists(id))
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

        // POST: api/BloodCamps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BloodCamp>> PostBloodCamp(BloodCamp bloodCamp)
        {
            _context.BloodCamps.Add(bloodCamp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBloodCamp", new { id = bloodCamp.ID }, bloodCamp);
        }

        // DELETE: api/BloodCamps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBloodCamp(int id)
        {
            var bloodCamp = await _context.BloodCamps.FindAsync(id);
            if (bloodCamp == null)
            {
                return NotFound();
            }

            _context.BloodCamps.Remove(bloodCamp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BloodCampExists(int id)
        {
            return _context.BloodCamps.Any(e => e.ID == id);
        }
    }
}
