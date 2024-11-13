using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gestao_Administrativa.Domain.Models;
using Gestao_Administrativa.Repository.Data;

namespace Gestao_Administrativa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAddressModelsController : ControllerBase
    {
        private readonly SubscriptionManagementDBContext _context;

        public CustomerAddressModelsController(SubscriptionManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/CustomerAddressModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerAddressModel>>> GetCustomerAddress()
        {
            return await _context.CustomerAddress.ToListAsync();
        }

        // GET: api/CustomerAddressModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerAddressModel>> GetCustomerAddressModel(int id)
        {
            var customerAddressModel = await _context.CustomerAddress.FindAsync(id);

            if (customerAddressModel == null)
            {
                return NotFound();
            }

            return customerAddressModel;
        }

        // PUT: api/CustomerAddressModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerAddressModel(int id, CustomerAddressModel customerAddressModel)
        {
            if (id != customerAddressModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerAddressModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerAddressModelExists(id))
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

        // POST: api/CustomerAddressModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerAddressModel>> PostCustomerAddressModel(CustomerAddressModel customerAddressModel)
        {
            _context.CustomerAddress.Add(customerAddressModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerAddressModel", new { id = customerAddressModel.Id }, customerAddressModel);
        }

        // DELETE: api/CustomerAddressModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerAddressModel(int id)
        {
            var customerAddressModel = await _context.CustomerAddress.FindAsync(id);
            if (customerAddressModel == null)
            {
                return NotFound();
            }

            _context.CustomerAddress.Remove(customerAddressModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerAddressModelExists(int id)
        {
            return _context.CustomerAddress.Any(e => e.Id == id);
        }
    }
}
