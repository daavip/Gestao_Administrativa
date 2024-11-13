using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Gestao_Administrativa.Domain.Models;
using Gestao_Administrativa.Repository.Data;
using Gestao_Administrativa.Domain.Interface.Service;
using Shared.API.Controllers;

namespace Gestao_Administrativa.API.Controllers
{
    //[Route("[controller]")]
    //[ApiController]
    //public class CustomerController : BaseController<CustomerModel, int?>
    //{
    //    public CustomerController(ICustomerService service, ILogger<CustomerController> loger) : base(service, loger)
    //    {
    //    }

    //}

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerModelsController : ControllerBase
    {
        private readonly SubscriptionManagementDBContext _context;

        public CustomerModelsController(SubscriptionManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/CustomerModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> GetCustomers()
        {
            return await _context.Customer.ToListAsync();
        }

        // GET: api/CustomerModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerModel>> GetCustomerModel(int id)
        {
            var customerModel = await _context.Customer.FindAsync(id);

            if (customerModel == null)
            {
                return NotFound();
            }

            return customerModel;
        }

        // PUT: api/UserModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserModel(int id, CustomerModel customerModel)
        {
            if (id != customerModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerModelExists(id))
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

        // POST: api/CustomerModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerModel>> PostUserModel(CustomerModel customerModel)
        {
            _context.Customer.Add(customerModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerModel", new { id = customerModel.Id }, customerModel);
        }

        // DELETE: api/CustomerModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerModel(int id)
        {
            var customerModel = await _context.Customer.FindAsync(id);
            if (customerModel == null)
            {
                return NotFound();
            }

            _context.Customer.Remove(customerModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerModelExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}
