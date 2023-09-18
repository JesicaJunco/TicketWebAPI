using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket.API.Entidades;

namespace Ticket.API.Repositorios;

public class TipoServicioRepositorio: ITipoServicioRepositorio
{
    public List<TipoServicio> ListarTodosTipoServicio()
    {
        List<TipoServicio> servicio = new List<TipoServicio>();
        servicio.Add(new TipoServicio()
        {
            IdTipoServicio = 1,
            NombreServicio = "Gas"
        });
        servicio.Add(new TipoServicio()
        {
            IdTipoServicio = 2,
            NombreServicio = "Agua"
        });
        servicio.Add(new TipoServicio()
        {
            IdTipoServicio = 3,
            NombreServicio = "Electricidad"
        });
        servicio.Add(new TipoServicio()
        {
            IdTipoServicio = 4,
            NombreServicio = "Internet"
        });
        servicio.Add(new TipoServicio()
        {
            IdTipoServicio = 5,
            NombreServicio = "Servicios Sociales"
        });
        servicio.Add(new TipoServicio()
        {
            IdTipoServicio = 6,
            NombreServicio = "Recolección de Residuos"
        });
        return servicio;
    }
    public bool AgregarTipoServicio(TipoServicio servicio)
    {
       

        return true;
    }
    public bool EliminaripoServicio(TipoServicio servicio)
    {
        return true;
    }
    public bool ActualizarTipoServicio(TipoServicio servicio)
    {
        return true;
    }

    public bool EliminarTipoServicio(int IdTipoServicio)
    {
        throw new NotImplementedException();
    }
}
