using Gestão_Administrativa.Data;
using Gestão_Administrativa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

[Route("api/[controller]")]
[ApiController]
public class ClientesController : ControllerBase
{
    private readonly SubscriptionManagementDBContext _context;

    public ClientesController(SubscriptionManagementDBContext context)
    {
        _context = context;
    }

    // GET: api/Clientes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserModel>>> GetClientes()
    {
        return await _context.Users.ToListAsync();
    }

    // GET: api/Clientes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<UserModel>> GetCliente(int id)
    {
        var cliente = await _context.Users.FindAsync(id);

        if (cliente == null)
        {
            return NotFound();
        }

        return cliente;
    }

    // POST: api/Clientes
    [HttpPost]
    public async Task<ActionResult<UserModel>> PostCliente(UserModel cliente)
    {
        _context.Users.Add(cliente);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
    }

    // PUT: api/Clientes/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCliente(int id, UserModel cliente)
    {
        if (id != cliente.Id)
        {
            return BadRequest();
        }

        _context.Entry(cliente).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ClienteExists(id))
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

    // DELETE: api/Clientes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCliente(int id)
    {
        var cliente = await _context.Users.FindAsync(id);
        if (cliente == null)
        {
            return NotFound();
        }

        _context.Users.Remove(cliente);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ClienteExists(int id)
    {
        return _context.Users.Any(e => e.Id == id);
    }
}
