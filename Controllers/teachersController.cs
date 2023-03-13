using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1_Kaluta.Data;
using WebApplication1_Kaluta.Models;

namespace WebApplication1_Kaluta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class teachersController : ControllerBase
    {
        private readonly WebApplication1_KalutaContext _context;

        public teachersController(WebApplication1_KalutaContext context)
        {
            _context = context;
        }

        // GET: api/teachers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<teachers>>> GetTeachers()
        {
            return await _context.Teachers.ToListAsync();
        }

        // GET: api/teachers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<teachers>> Getteachers(int id)
        {
            var teachers = await _context.Teachers.FindAsync(id);

            if (teachers == null)
            {
                return NotFound();
            }

            return teachers;
        }

        // PUT: api/teachers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putteachers(int id, teachers teachers)
        {
            if (id != teachers.Id)
            {
                return BadRequest();
            }

            _context.Entry(teachers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!teachersExists(id))
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

        // POST: api/teachers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<teachers>> Postteachers(teachers teachers)
        {
            _context.Teachers.Add(teachers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getteachers", new { id = teachers.Id }, teachers);
        }

        // DELETE: api/teachers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteteachers(int id)
        {
            var teachers = await _context.Teachers.FindAsync(id);
            if (teachers == null)
            {
                return NotFound();
            }

            _context.Teachers.Remove(teachers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool teachersExists(int id)
        {
            return _context.Teachers.Any(e => e.Id == id);
        }
    }
}
