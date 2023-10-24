using Ticket.API.Entidades;
using Ticket.API.Repositorios;
using Ticket.API.Servicios;
using Ticket.API.Servicios.Interfaces;

public class PrioridadTicketServicio : IPrioridadTicketServicio
{
     private readonly IPrioridadTicketRepositorio _prioridadTicketRepositorio;

    public PrioridadTicketServicio(IPrioridadTicketRepositorio prioridadTicketRepositorio){
        _prioridadTicketRepositorio = prioridadTicketRepositorio;
    } 
     public bool ActualizarPrioridadTicket(PrioridadTicket prioridadTicket)
    {
        PrioridadTicket prioridadTicketVerificacion = BuscarPrioridadTicket(prioridadTicket.IdPrioridadTicket);
        if(prioridadTicketVerificacion != null){
            return _prioridadTicketRepositorio.ActualizarPrioridadTicket(prioridadTicket);
       }
       return false;
    } 

    public bool AgregarPrioridadTicket(PrioridadTicket prioridadTicket)
    {
        throw new NotImplementedException();
    }

     public PrioridadTicket BuscarPrioridadTicket(int idPrioridadTicket)
    {
        return _prioridadTicketRepositorio.BuscarPrioridadTicket(idPrioridadTicket);
    }

    public bool EliminarPrioridadTicket(int idPrioridadTicket)
    {
        return _prioridadTicketRepositorio.EliminarPrioridadTicket(idPrioridadTicket);
    }

    public List<PrioridadTicket> ListarPrioridadTicket()
    {
        return _prioridadTicketRepositorio.ListarPrioridadTicket();
    } 

    public bool EsPrioridadTicket(){
        return true;
    }
}