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
    public class TipoServicioController: ControllerBase
    {    
    private readonly ILogger<TipoServicioController> _logger;
    private readonly ITipoServicioRepositorio _tipoServicioRepositorio;
    
    public TipoServicioController(ITipoServicioRepositorio tipoServicioRepositorio, ILogger<TipoServicioController> logger)
    {
        _tipoServicioRepositorio = tipoServicioRepositorio;
        _logger = logger;
    }

    [HttpGet()]
    public IActionResult ObtenerTipoServicio()
    {
        List <TipoServicio> resultado = _tipoServicioRepositorio.ListarTodosTipoServicio();
        return Ok(resultado);


    }
     [HttpPost()]
    public IActionResult  AgregarTipoServicio(TipoServicio tipoServicio)
    {
        if (tipoServicio.IdTipoServicio <= 0)
        {
            return BadRequest();
        }

        _tipoServicioRepositorio.AgregarTipoServicio(tipoServicio);

        return Ok();
        
    }
    }
