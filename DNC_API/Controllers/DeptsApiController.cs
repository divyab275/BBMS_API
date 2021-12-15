using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DNC_API.Models;
using Microsoft.AspNetCore.Authorization;

namespace DNC_API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DeptsApiController : ControllerBase
    {
        private readonly ProvidenceDbContext _context;

        public DeptsApiController(ProvidenceDbContext context)
        {
            _context = context;
        }

        // GET: api/DeptsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dept>>> GetDepts()
        {
            return await _context.Depts.ToListAsync();
        }

        // GET: api/DeptsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dept>> GetDept(int id)
        {
            var dept = await _context.Depts.FindAsync(id);

            if (dept == null)
            {
                return NotFound();
            }

            return dept;
        }

        [HttpGet("GetByLocation/{location}")] //[action]/{location} thia makes it dynamic
        public async Task<ActionResult<IEnumerable<Dept>>> GetDept(string location)
        {
            var depts = await _context.Depts.Where(d => d.Location == location).ToListAsync();

            Response.Headers.Add($"Dept-Count-At-{location}", depts.Count.ToString()); //To send response in headers

            if (depts.Count == 0)
            {
                return NotFound();
            }

            return depts;
        }

        // PUT: api/DeptsApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDept(int id, Dept dept)
        {
            if (id != dept.DeptNo)
            {
                return BadRequest();
            }

            _context.Entry(dept).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeptExists(id))
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

        // POST: api/DeptsApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dept>> PostDept(Dept dept)
        {
            _context.Depts.Add(dept);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DeptExists(dept.DeptNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDept", new { id = dept.DeptNo }, dept);
        }

        // DELETE: api/DeptsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDept(int id)
        {
            var dept = await _context.Depts.FindAsync(id);
            if (dept == null)
            {
                return NotFound();
            }

            _context.Depts.Remove(dept);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeptExists(int id)
        {
            return _context.Depts.Any(e => e.DeptNo == id);
        }
    }
}
