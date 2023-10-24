using Ticket.API.Entidades;
using Ticket.API.Repositorios.Interfaces;

namespace Ticket.API.Repositorios;

public class PrioridadTicketRepositorio : IPrioridadTicketRepositorio
{
    private readonly TicketAppContext _ticketAppContext;

    public PrioridadTicketRepositorio(TicketAppContext ticketAppContext)
    {
        _ticketAppContext = ticketAppContext;
    }
    public bool ActualizarPrioridadTicket(PrioridadTicket prioridadTicket)
    {
        PrioridadTicket prioridadTicketDB = _ticketAppContext.PrioridadTicket.Where(p => p.IdPrioridadTicket == prioridadTicket.IdPrioridadTicket).First();

        prioridadTicketDB.NombrePrioridad = prioridadTicket.NombrePrioridad;

        _ticketAppContext.Update(prioridadTicketDB);
        _ticketAppContext.SaveChanges();
        return true;
    }

    public bool AgregarPrioridadTicket(PrioridadTicket prioridadTicket)
    {
        _ticketAppContext.PrioridadTicket.Add(prioridadTicket);
        _ticketAppContext.SaveChanges();
        return true;
    }

    public PrioridadTicket BuscarPrioridadTicket(int IdPrioridadTicket)
    {
        return _ticketAppContext.PrioridadTicket.Where(p => p.IdPrioridadTicket == IdPrioridadTicket).First();
    } 
    public bool EliminarPrioridadTicket(int IdPrioridadTicket)
    {
        PrioridadTicket prioridadTicketDB = _ticketAppContext.PrioridadTicket.Where(p => p.IdPrioridadTicket == IdPrioridadTicket).First();

        _ticketAppContext.Remove(prioridadTicketDB);
        _ticketAppContext.SaveChanges();

        return true;
    } 

     public List<PrioridadTicket> ListarPrioridadTicket()
    {
        return _ticketAppContext.PrioridadTicket.ToList();
    }

    public bool EsPrioridadTicket()
    {
        return true;
    }
}