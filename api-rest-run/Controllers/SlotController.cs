using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_rest_run.Models;

namespace api_rest_run.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotController : ControllerBase
    {
        private readonly TestDbContext _context;

        public SlotController(TestDbContext context)
        {
            _context = context;
        }

        // GET: api/Slot
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Slot>>> GetSlots()
        {
          if (_context.Slots == null)
          {
              return NotFound();
          }
            return await _context.Slots.ToListAsync();
        }

        // GET: api/Slot/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Slot>> GetSlot(string id)
        {
          if (_context.Slots == null)
          {
              return NotFound();
          }
            var slot = await _context.Slots.FindAsync(id);

            if (slot == null)
            {
                return NotFound();
            }

            return slot;
        }

        // PUT: api/Slot/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlot(string id, Slot slot)
        {
            if (id != slot.SlotNumber)
            {
                return BadRequest();
            }

            _context.Entry(slot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlotExists(id))
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

        // POST: api/Slot
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Slot>> PostSlot(Slot slot)
        {
          if (_context.Slots == null)
          {
              return Problem("Entity set 'TestDbContext.Slots'  is null.");
          }
            _context.Slots.Add(slot);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SlotExists(slot.SlotNumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSlot", new { id = slot.SlotNumber }, slot);
        }

        // DELETE: api/Slot/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSlot(string id)
        {
            if (_context.Slots == null)
            {
                return NotFound();
            }
            var slot = await _context.Slots.FindAsync(id);
            if (slot == null)
            {
                return NotFound();
            }

            _context.Slots.Remove(slot);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SlotExists(string id)
        {
            return (_context.Slots?.Any(e => e.SlotNumber == id)).GetValueOrDefault();
        }
    }
}
