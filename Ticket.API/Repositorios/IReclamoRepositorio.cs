using Ticket.API.Entidades;

namespace Ticket.API.Repositorios;

    public interface IReclamoRepositorio
    {
        bool ActualizarReclamo(Reclamo reclamo);
        bool AgregarReclamo(Reclamo reclamo);
        bool EliminarReclamo(int NroTicketReclamo);

        List <Reclamo> ListarTodosReclamos();
    }
