using Ticket.API.Entidades;
namespace Ticket.API.Servicios.Interfaces;

public interface IPrioridadTicketServicio{
    bool ActualizarPrioridadTicket(PrioridadTicket prioridadTicket);
    bool AgregarPrioridadTicket(PrioridadTicket prioridadTicket);
    bool EliminarPrioridadTicket(int idPrioridadTicket);
    public PrioridadTicket BuscarPrioridadTicket(int idPrioridadTicket);
    List<PrioridadTicket> ListarPrioridadTicket();
}