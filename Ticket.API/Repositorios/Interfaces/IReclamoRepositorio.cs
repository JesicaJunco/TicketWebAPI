using Ticket.API.Entidades;

namespace Ticket.API.Repositorios.Interfaces;

    public interface IReclamoRepositorio
    {
        bool ActualizarReclamo(Reclamo reclamo);
        bool AgregarReclamo(Reclamo reclamo);
        bool EliminarReclamo(int NroTicketReclamo);

        List <Reclamo> ListarReclamos();
        public Reclamo BuscarReclamo(int NroTicketReclamo);
    }
