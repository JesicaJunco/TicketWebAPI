using Microsoft.AspNetCore.Mvc;
using Ticket.API.Entidades;
using Ticket.API.Repositorios;
using Ticket.API.Servicios.Interfaces;

namespace Ticket.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EstadoTicketController : ControllerBase
{
    private readonly ILogger<EstadoTicketController> _logger;
    private readonly IEstadoTicketServicio _estadoTicketServicio;

    public EstadoTicketController(IEstadoTicketServicio _estadoTicketServicio, ILogger<EstadoTicketController> logger)
    {
        _estadoTicketServicio = _estadoTicketServicio;
        _logger = logger;

    }
    [HttpGet()]
    public IActionResult ObtenerEstadoTicket()
    {
        List<EstadoTicket> resultado = _estadoTicketServicio.ListarEstadoTicket();
        return Ok(resultado);

    }

    [HttpGet("{estadoTicket}")]
    public IActionResult BuscarEstadoTicket(int IdEstado)
    {
        EstadoTicket estadoTicket = _estadoTicketServicio.BuscarEstadoTicket(IdEstado);
        return Ok(estadoTicket);
    }

    [HttpPost()]
    public IActionResult AgregarEstadoTicket(EstadoTicket estadoTicket)
    {
        if (estadoTicket.IdEstado <= 0)
        {
            return BadRequest();
        }

        _estadoTicketServicio.AgregarEstadoTicket(estadoTicket);

        return Ok();
    }

    [HttpPut()]
    public IActionResult ModificarEstadoTicket(EstadoTicket estadoTicket)
    {
        _estadoTicketServicio.ActualizarEstadoTicket(estadoTicket);
        return Ok();
    }

    [HttpDelete("{estadoTicket}")]
    public IActionResult EliminarEstadoticket(int estadoTicket)
    {
        _estadoTicketServicio.EliminarEstadoTicket(estadoTicket);
        return Ok();
    }
}

