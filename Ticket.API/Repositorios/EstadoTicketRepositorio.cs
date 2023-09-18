using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket.API.Entidades;

namespace Ticket.API.Repositorios
{
    public class EstadoTicketRepositorio: IEstadoTicketRepositorio
    {
        public List<EstadoTicket> ListarTodosEstadoTicket()
        {
            List<EstadoTicket> estados = new List<EstadoTicket>();
            estados.Add(new EstadoTicket() { IdEstado = 1, NombreEstado = "Abierto" });
            estados.Add(new EstadoTicket() { IdEstado = 2, NombreEstado = "En Proceso" });
            estados.Add(new EstadoTicket() { IdEstado = 3, NombreEstado = "Cerrado" });
            return estados;
        }
        public bool AgregarEstadoTicket(EstadoTicket estadoTicket)
        {
            return true;
        }
        public bool EliminarEstadoTicket(EstadoTicket estadoTicket)
        {
            return true;
        }
        public bool ActualizarEstadoTicket(EstadoTicket estadoTicket)
        {
            return true;
        }

        public bool EliminarEstadoTicket(int IdEstado)
        {
            throw new NotImplementedException();
        }
    }
}
