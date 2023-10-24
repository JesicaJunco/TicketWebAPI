using Ticket.API.Entidades;

namespace Ticket.API.Repositorios;

public interface IPrioridadTicketRepositorio
{
    bool ActualizarPrioridadTicket(PrioridadTicket prioridadTicket);
    bool AgregarPrioridadTicket(PrioridadTicket prioridadTicket);
    bool EliminarPrioridadTicket(int IdPrioridadTicket);
    public PrioridadTicket BuscarPrioridadTicket(int IdPrioridadTicket);
    List<PrioridadTicket> ListarPrioridadTicket();
} 
