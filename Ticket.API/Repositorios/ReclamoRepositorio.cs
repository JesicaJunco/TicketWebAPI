using Ticket.API.Entidades;
using Ticket.API.Repositorios.Interfaces;

namespace Ticket.API.Repositorios;

public class ReclamoRepositorio: IReclamoRepositorio
{
    private readonly TicketAppContext _ticketAppContext;

    public ReclamoRepositorio(TicketAppContext ticketAppContext){
        _ticketAppContext = ticketAppContext;
    }

    public bool AgregarReclamo (Reclamo reclamo)
    {
        reclamo.NroTicketReclamo = reclamo.GetHashCode();
        _ticketAppContext.Add(reclamo);
        _ticketAppContext.SaveChanges();

        return true;
    }

    public Reclamo BuscarReclamo(int NroTicketReclamo){
        return _ticketAppContext.Reclamo.Where(p => p.NroTicketReclamo == NroTicketReclamo).First();
    }
    public bool ActualizarReclamo (Reclamo reclamo)
    {
        //Buscar empleado en la base de datos
        Reclamo reclamoDB = _ticketAppContext.Reclamo.Where(p => p.NroTicketReclamo == reclamo.NroTicketReclamo).First();
        reclamoDB.ApellidoCliente = reclamo.ApellidoCliente;
        reclamoDB.NombreCliente = reclamo.NombreCliente;

        _ticketAppContext.Update(reclamoDB);
        _ticketAppContext.SaveChanges();

        return true;
    }

    public bool EliminarReclamo(int NroTicketReclamo)
    {
       //Eliminar reclamo de la base de datos
       Reclamo reclamoDB = _ticketAppContext.Reclamo.Where(p => p.NroTicketReclamo == NroTicketReclamo).First();

       _ticketAppContext.Remove(reclamoDB);
       _ticketAppContext.SaveChanges();

       return true;
    }
    public List<Reclamo> ListarReclamos()
    {
         return _ticketAppContext.Reclamo.ToList();
    }
}