using Ticket.API.Entidades;

namespace Ticket.API.Repositorios;

    public interface IEstadoTicketRepositorio
{
    bool ActualizarEstadoTicket(EstadoTicket estadoTicket);
    bool AgregarEstadoTicket(EstadoTicket estadoTicket);
    public EstadoTicket BuscarEstadoTicket(int idEstado);
    bool EliminarEstadoTicket(int IdEstado);
    List<EstadoTicket> ListarEstadoTicket();
}
