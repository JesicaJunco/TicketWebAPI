using Ticket.API.Entidades;

namespace Ticket.API.Repositorios;

public class ReclamoRepositorio: IReclamoRepositorio
{
    public List<Reclamo> ListarTodosReclamo()
    {
        List<Reclamo> reclamos = new List<Reclamo>();
        reclamos.Add(new Reclamo(){ NroTicketReclamo= 2345 , ApellidoCliente="Junco",NombreCliente="Jesica",CorreoCliente="jesibjunco@hotmail.com",DomicilioCliente="25 de mayo 331",TelefonoCliente=3483-640306,DescripcionReclamo="caño roto",OperadorTicketReclamo="Joa",FechaTicket= new DateTime(2023,06,02), HoraTicket= new (), ObservacionReclamo=""});
        reclamos.Add(new Reclamo(){ NroTicketReclamo= 2346 , ApellidoCliente="Diaz",NombreCliente="Pedro",CorreoCliente="pedrito@hotmail.com",DomicilioCliente="San Martin 3454",TelefonoCliente=2421-434548,DescripcionReclamo="arbol caido",OperadorTicketReclamo="Joa",FechaTicket= new DateTime(2023,06,12), HoraTicket= new (), ObservacionReclamo=""});
        

        return reclamos;
    }

    public bool AgregarReclamo (Reclamo reclamo)
    {
        return true;
    }
    public bool EliminarReclamo (Reclamo reclamo)
    {
        return true;
    }
    public bool ActualizarReclamo (Reclamo reclamo)
    {
        return true;
    }

    public bool EliminarReclamo(int NroTicketReclamo)
    {
        throw new NotImplementedException();
    }

    public List<Reclamo> ListarTodosReclamos()
    {
        throw new NotImplementedException();
    }
}