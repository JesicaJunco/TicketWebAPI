using Ticket.API.Entidades;
namespace Ticket.API.Servicios.Interfaces;

public interface IReclamoServicio{
     bool ActualizarReclamo(Reclamo reclamo);
    bool AgregarReclamo(Reclamo reclamo);
    bool EliminarReclamo(int NroTicketReclamo);
    public Reclamo BuscarReclamo(int NroTicketReclamo);
    List<Reclamo> ListarReclamo();
}