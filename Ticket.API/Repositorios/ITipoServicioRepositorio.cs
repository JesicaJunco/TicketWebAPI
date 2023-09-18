using Ticket.API.Entidades;

namespace Ticket.API.Repositorios;

public interface ITipoServicioRepositorio
{
    bool ActualizarTipoServicio(TipoServicio tipoServicio);
    bool AgregarTipoServicio(TipoServicio pltipoServicio);
    bool EliminarTipoServicio(int IdTipoServicio);
    List<TipoServicio> ListarTodosTipoServicio();
}
