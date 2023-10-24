using Ticket.API.Entidades;
using Ticket.API.Repositorios.Interfaces;

namespace Ticket.API.Repositorios;

public class TipoServicioRepositorio : ITipoServicioRepositorio
{
  private readonly TicketAppContext _ticketAppContext;

    public TipoServicioRepositorio(TicketAppContext ticketAppContext){
        _ticketAppContext = ticketAppContext;
    }
        public bool EliminarTipoServicio(int IdTipoServicio)
    {
        TipoServicio tipoServicioDB = _ticketAppContext.TipoServicio.Where(p => p.IdTipoServicio == IdTipoServicio).First();
        _ticketAppContext.Remove(tipoServicioDB);
        _ticketAppContext.SaveChanges();
        return true;
    }

    public TipoServicio BuscarTipoServicio(int IdPrioridadTicket)
    {
        return _ticketAppContext.TipoServicio.Where(p => p.IdTipoServicio == IdPrioridadTicket).First();
    }

    public List<TipoServicio> ListarTipoServicio()
    {
        return _ticketAppContext.TipoServicio.ToList();
    }

    public bool ActualizarTipoServicio(TipoServicio tipoServicio)
    {
        TipoServicio tipoServicioDB = _ticketAppContext.TipoServicio.Where(p => p.IdTipoServicio == tipoServicio.IdTipoServicio).First();

        tipoServicioDB.NombreServicio = tipoServicio.NombreServicio;

        _ticketAppContext.Update(tipoServicioDB);
        _ticketAppContext.SaveChanges();
        return true;
    }

    public bool AgregarTipoServicio(TipoServicio tipoServicio)
    {
        _ticketAppContext.TipoServicio.Add(tipoServicio);
        _ticketAppContext.SaveChanges();
        return true;
    }

    public bool EsTipoServicio(){
        return true;
    } 
}
