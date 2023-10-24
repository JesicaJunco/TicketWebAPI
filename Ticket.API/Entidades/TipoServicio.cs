using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.API.Entidades;

public class TipoServicio{
    [Key]
    [Column("idtiposervicio")]
    public int IdTipoServicio{get; set;}
    [Column("nombreservicio")]
    public string NombreServicio{get; set;}
} 

