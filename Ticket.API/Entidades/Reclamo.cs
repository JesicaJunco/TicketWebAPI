using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.API.Entidades;

public class Reclamo
{
    [Key]
    [Column("nroticketreclamo")]
    public int NroTicketReclamo { get; set; }

    [Column("apellidocliente")]
    public string ApellidoCliente { get; set; }

    [Column("nombrecliente")]
    public string NombreCliente { get; set; }

    [Column("correocliente")]
    public string CorreoCliente { get; set; }

    [Column("domiciliocliente")]
    public string DomicilioCliente { get; set; }

    [Column("telefonocliente")]
    public string TelefonoCliente { get; set; }

    [Column("descripcionreclamo")]
    public string DescripcionReclamo { get; set; }

    [Column("tiposervicio")]

   public string TipoServicio {get; set;}

   [Column("operadorticketreclamo")]
    public string OperadorTicketReclamo {get; set;}

    [Column("fechaticket")]
    public int FechaTicket { get; set; }

    [Column("estadoticket")]
    public string EstadoTicket {get; set;}

    [Column("prioridadticket")]
    public string PrioridadTicket{get; set;}

    [Column("observacionreclamo")]
    public string ObservacionReclamo {get; set;}

}
