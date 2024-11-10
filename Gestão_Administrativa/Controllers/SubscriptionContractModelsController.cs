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
    public class SubscriptionContractModelsController : ControllerBase
    {
        private readonly SubscriptionManagementDBContext _context;

        public SubscriptionContractModelsController(SubscriptionManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/SubscriptionContractModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionContractModel>>> GetSubscriptionContract()
        {
            return await _context.SubscriptionContract.ToListAsync();
        }

        // GET: api/SubscriptionContractModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubscriptionContractModel>> GetSubscriptionContractModel(int id)
        {
            var subscriptionContractModel = await _context.SubscriptionContract.FindAsync(id);

            if (subscriptionContractModel == null)
            {
                return NotFound();
            }

            return subscriptionContractModel;
        }

        // PUT: api/SubscriptionContractModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubscriptionContractModel(int id, SubscriptionContractModel subscriptionContractModel)
        {
            if (id != subscriptionContractModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(subscriptionContractModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubscriptionContractModelExists(id))
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

        // POST: api/SubscriptionContractModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubscriptionContractModel>> PostSubscriptionContractModel(SubscriptionContractModel subscriptionContractModel)
        {
            _context.SubscriptionContract.Add(subscriptionContractModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubscriptionContractModel", new { id = subscriptionContractModel.Id }, subscriptionContractModel);
        }

        // DELETE: api/SubscriptionContractModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubscriptionContractModel(int id)
        {
            var subscriptionContractModel = await _context.SubscriptionContract.FindAsync(id);
            if (subscriptionContractModel == null)
            {
                return NotFound();
            }

            _context.SubscriptionContract.Remove(subscriptionContractModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubscriptionContractModelExists(int id)
        {
            return _context.SubscriptionContract.Any(e => e.Id == id);
        }
    }
}
