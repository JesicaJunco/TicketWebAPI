using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.API.Entidades;

public class EstadoTicket {
    [Key]
    [Column("idestado")]
    public int IdEstado {get; set;}
    [Column("nombreestado")]
    public string NombreEstado{get; set;}
    
}