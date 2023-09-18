using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket.API.Entidades;

namespace Ticket.API.Repositorios;

    public class PrioridadTicketRepositorio: IPrioridadTicketRepositorio
    {
        public List<PrioridadTicket> ListarTodosPrioridadTicket()
        {
            List<PrioridadTicket> prioridad = new List<PrioridadTicket>();
            prioridad.Add(new PrioridadTicket()
            {
                IdPrioridadTicket = 1,
                NombrePrioridad = "Alta"
            });
            prioridad.Add(new PrioridadTicket()
            {
                IdPrioridadTicket = 2,
                NombrePrioridad = "Media"
            });
            prioridad.Add(new PrioridadTicket()
            {
                IdPrioridadTicket = 3,
                NombrePrioridad = "Baja"
            });
            return prioridad;
        }
    
    public bool AgregarPrioridad (PrioridadTicket prioridad)
    {
        return true;
    }
    public bool EliminarPrioridad (PrioridadTicket prioridad)
    {
        return true;
    }
    public bool ActualizarPrioridad (PrioridadTicket prioridad)
    {
        return true;
    }

    public bool ActualizarPrioridadTicket(PrioridadTicket prioridadTicket)
    {
        throw new NotImplementedException();
    }

    public bool AgregarPrioridadTicket(PrioridadTicket prioridadTicket)
    {
        throw new NotImplementedException();
    }

    public bool EliminarPrioridadTicket(int IdPrioridadTicket)
    {
        throw new NotImplementedException();
    }
}