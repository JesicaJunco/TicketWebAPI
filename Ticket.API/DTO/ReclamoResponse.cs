namespace Ticket.API.DTO;

public class ReclamoResponse
{
    public int NroTicketReclamo { get; set; }
    public string ApellidoCliente { get; set; }

    public string NombreCliente { get; set; }

    public string CorreoCliente { get; set; }

    public string DomicilioCliente { get; set; }

    public string TelefonoCliente { get; set; }

    public string DescripcionReclamo { get; set; }


   public string TipoServicio {get; set;}

    public string OperadorTicketReclamo {get; set;}

    public DateTime FechaTicket { get; set; }

    public string EstadoTicket {get; set;}

    public string PrioridadTicket{get; set;}

    public string ObservacionReclamo {get; set;}

}
