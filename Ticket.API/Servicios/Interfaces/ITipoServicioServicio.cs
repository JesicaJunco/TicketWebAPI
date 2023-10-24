using Ticket.API.Entidades;
namespace Ticket.API.Servicios.Interfaces;

public interface ITipoServicioServicio{
    bool ActualizarTipoServicio(TipoServicio tipoServicio);
    bool AgregarTipoServicio(TipoServicio tipoServicio);
    bool EliminarTipoServicio(int IdTipoServicio);
    public TipoServicio BuscarTipoServicio(int IdTipoServicio);
    List<TipoServicio> ListarTipoServicio(); 
}