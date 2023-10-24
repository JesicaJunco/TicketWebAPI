using Ticket.API.Entidades;
using Ticket.API.Repositorios.Interfaces;

namespace Ticket.API.Repositorios;

public class EstadoTicketRepositorio : IEstadoTicketRepositorio
{
    private readonly TicketAppContext _ticketAppContext;

    public EstadoTicketRepositorio(TicketAppContext ticketAppContext)
    {
        _ticketAppContext = ticketAppContext;
    }
     public bool AgregarEstadoTicket(EstadoTicket estadoTicket)
    {
        _ticketAppContext.EstadoTicket.Add(estadoTicket);
        _ticketAppContext.SaveChanges();
        return true;
    }
   public bool ActualizarEstadoTicket(EstadoTicket estadoTicket)
    {
        EstadoTicket estadoTicketDB = _ticketAppContext.EstadoTicket.Where(p => p.IdEstado == estadoTicket.IdEstado).First();

        estadoTicketDB.NombreEstado = estadoTicket.NombreEstado;
        
        _ticketAppContext.Update(estadoTicketDB);
        _ticketAppContext.SaveChanges();
        return true;
    } 

     public bool EliminarEstadoTicket(int IdEstado)
    {
        EstadoTicket estadoTicketDB = _ticketAppContext.EstadoTicket.Where(p => p.IdEstado == IdEstado).First();

        _ticketAppContext.Remove(estadoTicketDB);
        _ticketAppContext.SaveChanges();
        return true;
    } 

   public EstadoTicket BuscarEstadoTicket(int IdEstado)
    {
        return _ticketAppContext.EstadoTicket.Where(p => p.IdEstado == IdEstado).First();
    }
    public List<EstadoTicket> ListarEstadoTicket()
    {
        return _ticketAppContext.EstadoTicket.ToList();
    }

    public bool EstadoTicket(){
        return true;
    } 
}

