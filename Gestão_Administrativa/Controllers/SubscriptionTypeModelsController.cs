using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gestao_Administrativa.Domain.Models;
using Gestão_Administrativa.Repository.Data;

namespace Gestão_Administrativa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionTypeModelsController : ControllerBase
    {
        private readonly SubscriptionManagementDBContext _context;

        public SubscriptionTypeModelsController(SubscriptionManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/SubscriptionTypeModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionTypeModel>>> GetSubscriptionType()
        {
            return await _context.SubscriptionType.ToListAsync();
        }

        // GET: api/SubscriptionTypeModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubscriptionTypeModel>> GetSubscriptionTypeModel(int id)
        {
            var subscriptionTypeModel = await _context.SubscriptionType.FindAsync(id);

            if (subscriptionTypeModel == null)
            {
                return NotFound();
            }

            return subscriptionTypeModel;
        }

        // PUT: api/SubscriptionTypeModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubscriptionTypeModel(int id, SubscriptionTypeModel subscriptionTypeModel)
        {
            if (id != subscriptionTypeModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(subscriptionTypeModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubscriptionTypeModelExists(id))
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

        // POST: api/SubscriptionTypeModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubscriptionTypeModel>> PostSubscriptionTypeModel(SubscriptionTypeModel subscriptionTypeModel)
        {
            _context.SubscriptionType.Add(subscriptionTypeModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubscriptionTypeModel", new { id = subscriptionTypeModel.Id }, subscriptionTypeModel);
        }

        // DELETE: api/SubscriptionTypeModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubscriptionTypeModel(int id)
        {
            var subscriptionTypeModel = await _context.SubscriptionType.FindAsync(id);
            if (subscriptionTypeModel == null)
            {
                return NotFound();
            }

            _context.SubscriptionType.Remove(subscriptionTypeModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubscriptionTypeModelExists(int id)
        {
            return _context.SubscriptionType.Any(e => e.Id == id);
        }
    }
}
