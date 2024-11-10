﻿using System;
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
    public class ContactModelsController : ControllerBase
    {
        private readonly SubscriptionManagementDBContext _context;

        public ContactModelsController(SubscriptionManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/ContactModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactModel>>> GetContact()
        {
            return await _context.Contact.ToListAsync();
        }

        // GET: api/ContactModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactModel>> GetContactModel(int id)
        {
            var contactModel = await _context.Contact.FindAsync(id);

            if (contactModel == null)
            {
                return NotFound();
            }

            return contactModel;
        }

        // PUT: api/ContactModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactModel(int id, ContactModel contactModel)
        {
            if (id != contactModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(contactModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactModelExists(id))
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

        // POST: api/ContactModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContactModel>> PostContactModel(ContactModel contactModel)
        {
            _context.Contact.Add(contactModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactModel", new { id = contactModel.Id }, contactModel);
        }

        // DELETE: api/ContactModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactModel(int id)
        {
            var contactModel = await _context.Contact.FindAsync(id);
            if (contactModel == null)
            {
                return NotFound();
            }

            _context.Contact.Remove(contactModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactModelExists(int id)
        {
            return _context.Contact.Any(e => e.Id == id);
        }
    }
}
