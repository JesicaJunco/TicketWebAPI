using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
using System.Linq; 
using Ticket.API.Entidades;
using Ticket.API.Repositorios;

namespace Ticket.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReclamosController : ControllerBase
{    
    private readonly ILogger<ReclamosController> _logger;
    private readonly IReclamoRepositorio _reclamoRepositorio;

    private readonly TicketAppContext _context;
    
    public ReclamosController(IReclamoRepositorio reclamoRepositorio, ILogger<ReclamosController> logger, TicketAppContext context)
    {
        _reclamoRepositorio = reclamoRepositorio;
        _logger = logger;
        _context = context; 
    }

    [HttpGet()]
    public IActionResult ObtenerReclamo()
    {
        List<Reclamo> resultado = _reclamoRepositorio.ListarTodosReclamos();
        return Ok(resultado);

    }

     [HttpPost()]
    public IActionResult AgregarReclamo(Reclamo reclamo)
    {
        if (reclamo.NroTicketReclamo <= 0)
        {
            return BadRequest();
        }

        _reclamoRepositorio.AgregarReclamo(reclamo);

        return Ok();

    }
}
