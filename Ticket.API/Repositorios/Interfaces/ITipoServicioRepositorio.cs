using Ticket.API.Entidades;

namespace Ticket.API.Repositorios;

public interface ITipoServicioRepositorio
{
    bool ActualizarTipoServicio(TipoServicio tipoServicio);
    bool AgregarTipoServicio(TipoServicio tipoServicio);
    bool EliminarTipoServicio(int IdTipoServicio);
    public TipoServicio BuscarTipoServicio(int IdPrioridadTicket);
    List<TipoServicio> ListarTipoServicio();
}
