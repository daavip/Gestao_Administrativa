using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gestão_Administrativa.Repository.Data;
using Gestão_Administrativa.Domain.Models;

namespace Gestão_Administrativa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionModelsController : ControllerBase
    {
        private readonly SubscriptionManagementDBContext _context;

        public SubscriptionModelsController(SubscriptionManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/SubscriptionModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionModel>>> GetSubscriptions()
        {
            return await _context.Subscriptions.ToListAsync();
        }

        // GET: api/SubscriptionModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubscriptionModel>> GetSubscriptionModel(int id)
        {
            var subscriptionModel = await _context.Subscriptions.FindAsync(id);

            if (subscriptionModel == null)
            {
                return NotFound();
            }

            return subscriptionModel;
        }

        // PUT: api/SubscriptionModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubscriptionModel(int id, SubscriptionModel subscriptionModel)
        {
            if (id != subscriptionModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(subscriptionModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubscriptionModelExists(id))
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

        // POST: api/SubscriptionModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubscriptionModel>> PostSubscriptionModel(SubscriptionModel subscriptionModel)
        {
            _context.Subscriptions.Add(subscriptionModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubscriptionModel", new { id = subscriptionModel.Id }, subscriptionModel);
        }

        // DELETE: api/SubscriptionModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubscriptionModel(int id)
        {
            var subscriptionModel = await _context.Subscriptions.FindAsync(id);
            if (subscriptionModel == null)
            {
                return NotFound();
            }

            _context.Subscriptions.Remove(subscriptionModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubscriptionModelExists(int id)
        {
            return _context.Subscriptions.Any(e => e.Id == id);
        }
    }
}
