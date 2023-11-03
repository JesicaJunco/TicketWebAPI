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

        List<ReclamoDTO> resultadoDTO = _mapper.Map<List<Reclamo>, List<ReclamoDTO>>(resultado);
        return Ok(resultadoDTO);

    }

    [HttpGet("{NroTicketReclamo}")]
    public IActionResult BuscarReclamo(int NroTicketReclamo)
    {
        Reclamo resultado = _reclamoServicio.BuscarReclamo(NroTicketReclamo);

        ReclamoDTO resultadoDTO = _mapper.Map<Reclamo, ReclamoDTO>(resultado);
        return Ok(resultadoDTO);
    }

    [HttpPost()]
    public IActionResult AgregarReclamo(ReclamoDTO reclamoDTO)
    {
        if (reclamoDTO.NroTicketReclamo < 0)
        {
            return BadRequest();
        }

        // Usa AutoMapper para convertir ReclamoDTO a Reclamo
        Reclamo reclamo = _mapper.Map<ReclamoDTO, Reclamo>(reclamoDTO);
        _reclamoServicio.AgregarReclamo(reclamo);

        return Ok();
    }

    [HttpPut()]
    public IActionResult ModificarReclamo(ReclamoDTO ReclamoDTO)
    {
        Reclamo reclamo = _mapper.Map<ReclamoDTO, Reclamo>(ReclamoDTO);
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
