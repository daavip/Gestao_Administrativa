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
    public class ContractModelsController : ControllerBase
    {
        private readonly SubscriptionManagementDBContext _context;

        public ContractModelsController(SubscriptionManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/ContractModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContractModel>>> GetContract()
        {
            return await _context.Contract.ToListAsync();
        }

        // GET: api/ContractModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContractModel>> GetContractModel(int id)
        {
            var contractModel = await _context.Contract.FindAsync(id);

            if (contractModel == null)
            {
                return NotFound();
            }

            return contractModel;
        }

        // PUT: api/ContractModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContractModel(int id, ContractModel contractModel)
        {
            if (id != contractModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(contractModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContractModelExists(id))
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

        // POST: api/ContractModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContractModel>> PostContractModel(ContractModel contractModel)
        {
            _context.Contract.Add(contractModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContractModel", new { id = contractModel.Id }, contractModel);
        }

        // DELETE: api/ContractModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContractModel(int id)
        {
            var contractModel = await _context.Contract.FindAsync(id);
            if (contractModel == null)
            {
                return NotFound();
            }

            _context.Contract.Remove(contractModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContractModelExists(int id)
        {
            return _context.Contract.Any(e => e.Id == id);
        }
    }
}
