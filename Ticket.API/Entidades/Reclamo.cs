namespace Ticket.API.Entidades;

public class Reclamo
{
    public int NroTicketReclamo { get; set; }
    public string ApellidoCliente { get; set; }
    public string NombreCliente { get; set; }
    public string CorreoCliente { get; set; }
    public string DomicilioCliente { get; set; }

    public int TelefonoCliente { get; set; }
    public string DescripcionReclamo { get; set; }

   public TipoServicio TipoServicio {get; set;}
    public string OperadorTicketReclamo {get; set;}
    public DateTime FechaTicket { get; set; }
    public DateTime HoraTicket { get; set; }
    public EstadoTicket EstadoTicket {get; set;}
    public PrioridadTicket PrioridadTicket{get; set;}
    public string ObservacionReclamo {get; set;}

}
