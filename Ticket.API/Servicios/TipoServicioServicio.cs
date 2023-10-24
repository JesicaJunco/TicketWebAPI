using Ticket.API.Entidades;
using Ticket.API.Repositorios;
using Ticket.API.Servicios;
using Ticket.API.Servicios.Interfaces;

public class TipoServicioServicio : ITipoServicioServicio
{
    private readonly ITipoServicioRepositorio _tipoServicioRepositorio;
    public TipoServicioServicio(ITipoServicioRepositorio tipoServicioRepositorio){
        _tipoServicioRepositorio = tipoServicioRepositorio;
    }
    public bool ActualizarTipoServicio(TipoServicio tipoServicio)
    {
        TipoServicio tipoServicioVerificacion = BuscarTipoServicio(tipoServicio.IdTipoServicio);
        if(tipoServicioVerificacion != null){
            return _tipoServicioRepositorio.ActualizarTipoServicio(tipoServicio);
        }
        return false;
    }

    public bool AgregarTipoServicio(TipoServicio tipoServicio)
    {
        TipoServicio tipoServicioVerificacion = BuscarTipoServicio(tipoServicio.IdTipoServicio);
        if(tipoServicioVerificacion == null){
            return _tipoServicioRepositorio.AgregarTipoServicio(tipoServicio);
        }
        return false;
    }

    public TipoServicio BuscarTipoServicio(int IdTipoServicio)
    {
        return _tipoServicioRepositorio.BuscarTipoServicio(IdTipoServicio);
    }

    public bool EliminarTipoServicio(int IdTipoServicio)
    {
        return _tipoServicioRepositorio.EliminarTipoServicio(IdTipoServicio);
    }

    public List<TipoServicio> ListarTipoServicio()
    {
        return _tipoServicioRepositorio.ListarTipoServicio();
    }

    public bool EsTipoServicio(){
        return true;
    }
}

