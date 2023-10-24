using Ticket.API.Entidades;
using Ticket.API.Repositorios;
using Ticket.API.Servicios.Interfaces;
using Ticket.API.Servicios;

namespace Ticket.API.Servicios;

public class EstadoTicketServicio : IEstadoTicketServicio
{
    private readonly IEstadoTicketRepositorio _estadoTicketRepositorio;
   
    public EstadoTicketServicio(IEstadoTicketRepositorio estadoTicketRepositorio)
    {
        _estadoTicketRepositorio = estadoTicketRepositorio;
    }
    public bool ActualizarEstadoTicket(EstadoTicket estadoTicket)
    {
        EstadoTicket estadoTicketVerificacion = BuscarEstadoTicket(estadoTicket.IdEstado);
        if (estadoTicketVerificacion != null)
        {
            return _estadoTicketRepositorio.ActualizarEstadoTicket(estadoTicket);
        }
        return false;
    }

    public bool AgregarEstadoTicket(EstadoTicket estadoTicket)
    {
        EstadoTicket estadoTicketVerificacion = BuscarEstadoTicket(estadoTicket.IdEstado);
        if(estadoTicketVerificacion == null){
            return _estadoTicketRepositorio.AgregarEstadoTicket(estadoTicket);
        }
        return false;
    }

    public EstadoTicket BuscarEstadoTicket(int IdEstado) => _estadoTicketRepositorio.BuscarEstadoTicket(IdEstado);

    public bool EliminarEstadoTicket(int IdEstado)
    {
        return _estadoTicketRepositorio.EliminarEstadoTicket(IdEstado);
    }

    public List<EstadoTicket> ListarEstadoTicket()
    {
        return _estadoTicketRepositorio.ListarEstadoTicket();
    }

    public bool EstadoTicket(){
        return true;
    }
}