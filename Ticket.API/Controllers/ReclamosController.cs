using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ticket.API.DTO;
using Ticket.API.Entidades;
using Ticket.API.Servicios.Interfaces;

namespace Ticket.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReclamosController : ControllerBase
{    
    private readonly ILogger<ReclamosController> _logger;
    private readonly IReclamoServicio _reclamoServicio;  
    private readonly IMapper _mapper;  
    public ReclamosController(IReclamoServicio reclamoServicio, ILogger<ReclamosController>logger, IMapper mapper) {
        _reclamoServicio = reclamoServicio;
        _logger = logger;
        _mapper = mapper;
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
    public IActionResult AgregarReclamo(ReclamoDTO reclamoDTO)
    {
         if (reclamoDTO.NroTicketReclamo < 0)
        {
            return BadRequest();
        }

         // Usa AutoMapper para convertir ReclamoDTO a Reclamo
         Reclamo reclamo = _mapper.Map<Reclamo>(reclamoDTO);

      /*   Reclamo reclamo = new Reclamo()
       { 
            ApellidoCliente = reclamoDTO.ApellidoCliente,
            CorreoCliente = reclamoDTO.CorreoCliente,
            DescripcionReclamo = reclamoDTO.DescripcionReclamo,
            DomicilioCliente = reclamoDTO.DomicilioCliente,
            EstadoTicket = reclamoDTO.EstadoTicket,
            FechaTicket = reclamoDTO.FechaTicket,
            NombreCliente = reclamoDTO.NombreCliente,
            NroTicketReclamo = reclamoDTO.NroTicketReclamo,
            OperadorTicketReclamo = reclamoDTO.OperadorTicketReclamo,
            PrioridadTicket = reclamoDTO.PrioridadTicket,
            TelefonoCliente = reclamoDTO.TelefonoCliente,
            TipoServicio = reclamoDTO.TipoServicio, 
            ObservacionReclamo = reclamoDTO.ObservacionReclamo,

        };  */

 
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
