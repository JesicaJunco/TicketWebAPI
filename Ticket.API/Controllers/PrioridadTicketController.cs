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
public class PrioridadTicketController : ControllerBase
{
    private readonly ILogger<PrioridadTicketController> _logger;
    private readonly IPrioridadTicketRepositorio _prioridadTicketRepositorio;
    public PrioridadTicketController(IPrioridadTicketRepositorio prioridadTicketRepositorio, ILogger<PrioridadTicketController> logger)
    {
        _prioridadTicketRepositorio = prioridadTicketRepositorio;
        _logger = logger;

    }
   [HttpGet()]
    public IActionResult ObtenerPrioridadTicket()
    {
        List<PrioridadTicket> resultado =_prioridadTicketRepositorio.ListarTodosPrioridadTicket();
        return Ok(resultado);


    }
     [HttpPost()]
    public IActionResult AgregarPrioridadTicket (PrioridadTicket prioridadTicket)
    {
        if (prioridadTicket.IdPrioridadTicket <= 0)
        {
            return BadRequest();
        }

        _prioridadTicketRepositorio.AgregarPrioridadTicket(prioridadTicket);

        return Ok();
    }
    }
