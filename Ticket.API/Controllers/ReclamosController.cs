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
    public ReclamosController(IReclamoServicio reclamoServicio, ILogger<ReclamosController> logger, IMapper mapper)
    {
        _reclamoServicio = reclamoServicio;
        _logger = logger;
        _mapper = mapper;
    }

    [HttpGet()]
    public IActionResult ObtenerReclamo()
    {
        List<Reclamo> resultado = _reclamoServicio.ListarReclamo();

        List<ReclamoResponse> resultadoDTO = _mapper.Map<List<Reclamo>, List<ReclamoResponse>>(resultado);
        return Ok(resultadoDTO);

    }

    [HttpGet("{NroTicketReclamo}")]
    public IActionResult BuscarReclamo(int NroTicketReclamo)
    {
        Reclamo resultado = _reclamoServicio.BuscarReclamo(NroTicketReclamo);

        ReclamoResponse resultadoDTO = _mapper.Map<Reclamo, ReclamoResponse>(resultado);
        return Ok(resultadoDTO);
    }

    [HttpPost()]
    public IActionResult AgregarReclamo(ReclamoRequest reclamoDTO)
    {
        if (reclamoDTO.NroTicketReclamo < 0)
        {
            return BadRequest();
        }

        // Usa AutoMapper para convertir ReclamoDTO a Reclamo
        Reclamo reclamo = _mapper.Map<ReclamoRequest, Reclamo>(reclamoDTO);
        _reclamoServicio.AgregarReclamo(reclamo);

        return Ok();
    }

    [HttpPut()]
    public IActionResult ModificarReclamo(ReclamoRequest ReclamoDTO)
    {
        Reclamo reclamo = _mapper.Map<ReclamoRequest, Reclamo>(ReclamoDTO);
        _reclamoServicio.ActualizarReclamo(reclamo);

        return Ok();
    }

    [HttpDelete("{NroTicketReclamo}")]
    public IActionResult EliminarReclamo(int NroTicketReclamo)
    {
        _reclamoServicio.EliminarReclamo(NroTicketReclamo);

        return Ok();
    }
}
