using Microsoft.AspNetCore.Mvc;
using Ticket.API.Entidades;
using Ticket.API.Servicios.Interfaces;

namespace Ticket.API.Controllers;

[ApiController]
[Route("[controller]")]
    public class TipoServicioController: ControllerBase
    {    
    private readonly ILogger<TipoServicioController> _logger;
    private readonly ITipoServicioServicio _tipoServicioServicio;
    
    public TipoServicioController(ITipoServicioServicio tipoServicioServicio, ILogger<TipoServicioController> logger)
    {
        _tipoServicioServicio = tipoServicioServicio;
        _logger = logger;
    }

    [HttpGet()]
    public IActionResult ObtenerTipoServicio()
    {
        List <TipoServicio> resultado = _tipoServicioServicio.ListarTipoServicio();
        return Ok(resultado);
    }

    [HttpGet("{IdTipoServicio}")]
    public IActionResult BuscarTipoServicio(int IdTipoServicio){
        TipoServicio tipoServicio = _tipoServicioServicio.BuscarTipoServicio(IdTipoServicio);
        return Ok(tipoServicio);
    }

     [HttpPost()]
    public IActionResult  AgregarTipoServicio(TipoServicio tipoServicio)
    {
        if (tipoServicio.IdTipoServicio <= 0)
        {
            return BadRequest();
        }

        _tipoServicioServicio.AgregarTipoServicio(tipoServicio);

        return Ok();
    }

    [HttpPut()]
    public IActionResult ModificarTipoServicio(TipoServicio tipoServicio){
        _tipoServicioServicio.ActualizarTipoServicio(tipoServicio);
        return Ok();
    }

    [HttpDelete("{IdTipoServicio}")]
    public IActionResult EliminarTipoServicio(int IdTipoServicio){
        _tipoServicioServicio.EliminarTipoServicio(IdTipoServicio);
        return Ok();
    }
    }
