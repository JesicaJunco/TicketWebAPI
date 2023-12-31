using Ticket.API.Entidades;
using Ticket.API.Repositorios.Interfaces;
using Ticket.API.Servicios.Interfaces;

namespace Ticket.API.Servicios;

public class ReclamoServicio : IReclamoServicio
{

    private readonly IReclamoRepositorio _reclamoRepositorio;
    public ReclamoServicio(IReclamoRepositorio reclamoRepositorio)
    {
        _reclamoRepositorio = reclamoRepositorio;
    }

    public bool ActualizarReclamo(Reclamo reclamo)
    {
        Reclamo reclamoVerificacion = BuscarReclamo(reclamo.NroTicketReclamo);
        if(reclamoVerificacion != null){
            reclamoVerificacion.FechaTicket = reclamo.FechaTicket;
            return _reclamoRepositorio.ActualizarReclamo(reclamoVerificacion);
        }
        return false;
    }
    public bool AgregarReclamo(Reclamo reclamo)
    {
        Reclamo reclamoVerificacion = BuscarReclamo(reclamo.NroTicketReclamo);
        if(reclamoVerificacion == null){
            return _reclamoRepositorio.AgregarReclamo(reclamo);
        }
        return false;
    }
    public Reclamo BuscarReclamo(int NroTicketReclamo)
    {
        return _reclamoRepositorio.BuscarReclamo(NroTicketReclamo);
    }

    public bool EliminarReclamo(int NroTicketReclamo)
    {
        return _reclamoRepositorio.EliminarReclamo(NroTicketReclamo);
    }

    public List<Reclamo> ListarReclamo()
    {
        return _reclamoRepositorio.ListarReclamos();
    }

    public bool EsReclamo(){
        return true;
    }
}