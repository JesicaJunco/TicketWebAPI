using Ticket.API.Entidades;
namespace Ticket.API.Servicios.Interfaces;

public interface IEstadoTicketServicio{
    bool ActualizarEstadoTicket(EstadoTicket estadoTicket);
    bool AgregarEstadoTicket(EstadoTicket estadoTicket);
    bool EliminarEstadoTicket(int IdEstado);
    public EstadoTicket BuscarEstadoTicket(int IdEstado);
    List<EstadoTicket> ListarEstadoTicket(); 
}