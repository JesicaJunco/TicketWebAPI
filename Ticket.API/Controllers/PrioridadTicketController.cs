using Microsoft.AspNetCore.Mvc;
using Ticket.API.Entidades;
using Ticket.API.Repositorios;
using Ticket.API.Servicios.Interfaces;

namespace Ticket.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PrioridadTicketController : ControllerBase
{
    private readonly ILogger<PrioridadTicketController> _logger;
    private readonly IPrioridadTicketServicio _prioridadTicketServicio;
    public PrioridadTicketController(IPrioridadTicketServicio _prioridadTicketServicio, ILogger<PrioridadTicketController> logger)
    {
        _prioridadTicketServicio = _prioridadTicketServicio;
        _logger = logger;

    }
    [HttpGet()]
    public IActionResult ObtenerPrioridadTicket()
    {
        List<PrioridadTicket> resultado = _prioridadTicketServicio.ListarPrioridadTicket();
        return Ok(resultado);
    }

    [HttpGet("{IdPrioridadTicket}")]
    public IActionResult BuscarPrioridadTicket(int IdPrioridadTicket)
    {
        PrioridadTicket prioridadTicket = _prioridadTicketServicio.BuscarPrioridadTicket(IdPrioridadTicket);
        return Ok(prioridadTicket);
    }

    [HttpPost()]
    public IActionResult AgregarPrioridadTickek(PrioridadTicket prioridadTicket)
    {
        if (prioridadTicket.IdPrioridadTicket <= 0)
        {
            return BadRequest();
        }

        _prioridadTicketServicio.AgregarPrioridadTicket(prioridadTicket);

        return Ok();
    }

    [HttpPut()]
    public IActionResult ModificarPrioridadTicket(PrioridadTicket prioridadTicket)
    {
        _prioridadTicketServicio.ActualizarPrioridadTicket(prioridadTicket);
        return Ok();
    }

    [HttpDelete("{IdPrioridadTicket}")]
    public IActionResult EliminarPrioridadTicket(int IdPrioridadTicket)
    {
        _prioridadTicketServicio.EliminarPrioridadTicket(IdPrioridadTicket);
        return Ok();
    }
}
