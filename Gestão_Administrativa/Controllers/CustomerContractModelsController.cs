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
    public class CustomerContractModelsController : ControllerBase
    {
        private readonly SubscriptionManagementDBContext _context;

        public CustomerContractModelsController(SubscriptionManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/CustomerContractModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerContractModel>>> GetCustomerContract()
        {
            return await _context.CustomerContract.ToListAsync();
        }

        // GET: api/CustomerContractModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerContractModel>> GetCustomerContractModel(int id)
        {
            var customerContractModel = await _context.CustomerContract.FindAsync(id);

            if (customerContractModel == null)
            {
                return NotFound();
            }

            return customerContractModel;
        }

        // PUT: api/CustomerContractModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerContractModel(int id, CustomerContractModel customerContractModel)
        {
            if (id != customerContractModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerContractModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerContractModelExists(id))
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

        // POST: api/CustomerContractModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerContractModel>> PostCustomerContractModel(CustomerContractModel customerContractModel)
        {
            _context.CustomerContract.Add(customerContractModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerContractModel", new { id = customerContractModel.Id }, customerContractModel);
        }

        // DELETE: api/CustomerContractModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerContractModel(int id)
        {
            var customerContractModel = await _context.CustomerContract.FindAsync(id);
            if (customerContractModel == null)
            {
                return NotFound();
            }

            _context.CustomerContract.Remove(customerContractModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerContractModelExists(int id)
        {
            return _context.CustomerContract.Any(e => e.Id == id);
        }
    }
}
