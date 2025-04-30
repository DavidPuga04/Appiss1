using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Appiss1.Modelos;

namespace Appiss1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanRecompensasController : ControllerBase
    {
        private readonly SQLServerClienteSCP _context;

        public PlanRecompensasController(SQLServerClienteSCP context)
        {
            _context = context;
        }

        // GET: api/PlanRecompensas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanRecompensas>>> GetPlanRecompensas()
        {
            return await _context.PlanRecompensas.ToListAsync();
        }

        // GET: api/PlanRecompensas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlanRecompensas>> GetPlanRecompensas(int id)
        {
            var planRecompensas = await _context.PlanRecompensas.FindAsync(id);

            if (planRecompensas == null)
            {
                return NotFound();
            }

            return planRecompensas;
        }

        // PUT: api/PlanRecompensas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanRecompensas(int id, PlanRecompensas planRecompensas)
        {
            if (id != planRecompensas.Id)
            {
                return BadRequest();
            }

            _context.Entry(planRecompensas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanRecompensasExists(id))
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

        // POST: api/PlanRecompensas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlanRecompensas>> PostPlanRecompensas(PlanRecompensas planRecompensas)
        {
            _context.PlanRecompensas.Add(planRecompensas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlanRecompensas", new { id = planRecompensas.Id }, planRecompensas);
        }

        // DELETE: api/PlanRecompensas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanRecompensas(int id)
        {
            var planRecompensas = await _context.PlanRecompensas.FindAsync(id);
            if (planRecompensas == null)
            {
                return NotFound();
            }

            _context.PlanRecompensas.Remove(planRecompensas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanRecompensasExists(int id)
        {
            return _context.PlanRecompensas.Any(e => e.Id == id);
        }
    }
}
