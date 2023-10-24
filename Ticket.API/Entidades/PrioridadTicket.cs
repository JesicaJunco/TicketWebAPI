using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Ticket.API.Entidades;

public class PrioridadTicket
{
    [Key]
    [Column("idprioridadticket")]
    public int IdPrioridadTicket{get; set;}
    [Column("nombreprioridad")]
    public string NombrePrioridad{get; set;}
}