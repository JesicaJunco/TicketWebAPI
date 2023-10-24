using Microsoft.AspNetCore.Mvc;
using Ticket.API.Entidades;
using Ticket.API.Servicios.Interfaces;

namespace Ticket.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReclamosController : ControllerBase
{    
    private readonly ILogger<ReclamosController> _logger;
    private readonly IReclamoServicio _reclamoServicio;    
    public ReclamosController(IReclamoServicio reclamoServicio, ILogger<ReclamosController>logger) {
        _reclamoServicio = reclamoServicio;
        _logger = logger;
    }
    
    [HttpGet()]
    public IActionResult ObtenerReclamo()
    {
        List<Reclamo> resultado = _reclamoServicio.ListarReclamo();
        return Ok(resultado);

    }

    [HttpGet("{NroTicketReclamo}")]
    public IActionResult BuscarReclamo(int NroTicketReclamo){
        Reclamo resultado = _reclamoServicio.BuscarReclamo(NroTicketReclamo);
        return Ok(resultado);
    }

     [HttpPost()]
    public IActionResult AgregarReclamo(Reclamo reclamo)
    {
         if (reclamo.NroTicketReclamo < 0)
        {
            return BadRequest();
        }
 
         _reclamoServicio.AgregarReclamo(reclamo);

         return Ok();
    }

    [HttpPut()]
    public IActionResult ModificarReclamo(Reclamo reclamo){
        _reclamoServicio.ActualizarReclamo(reclamo);

        return Ok();
    }

    [HttpDelete("{NroTicketReclamo}")]
    public IActionResult EliminarReclamo(int NroTicketReclamo){
        _reclamoServicio.EliminarReclamo(NroTicketReclamo);

        return Ok();
    }
}
