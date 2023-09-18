using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ticket.API.Entidades;
using Ticket.API.Repositorios;

namespace Ticket.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EstadoTicketController : ControllerBase
{
    private readonly ILogger<EstadoTicketController> _logger;
    private readonly IEstadoTicketRepositorio _estadoTicketRepositorio;

    public EstadoTicketController(IEstadoTicketRepositorio estadoTicketRepositorio, ILogger<EstadoTicketController> logger)
    {
        _estadoTicketRepositorio = estadoTicketRepositorio;
        _logger = logger;

    }
    [HttpGet()]
    public IActionResult ObtenerEstadoTicket()
    {
        List<EstadoTicket> resultado = _estadoTicketRepositorio.ListarTodosEstadoTicket();
        return Ok(resultado);

    }
    [HttpPost()]
   public IActionResult AgregarEstadoTicket(EstadoTicket estadoTicket)
    {
       if (estadoTicket.IdEstado <= 0)
        {
            return BadRequest();
        }

        _estadoTicketRepositorio.AgregarEstadoTicket(estadoTicket);

        return Ok();
    }

    }

