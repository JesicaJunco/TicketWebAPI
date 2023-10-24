using Microsoft.EntityFrameworkCore;
using Ticket.API.Entidades;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Ticket.API.Repositorios
{
    public class TicketAppContext : DbContext
{
    public TicketAppContext(DbContextOptions<TicketAppContext> options)
        : base(options)
    {

    }

    public DbSet<Reclamo> Reclamo { get; set; }
    public DbSet<EstadoTicket> EstadoTicket { get; set; }
    public DbSet<PrioridadTicket> PrioridadTicket { get; set; }
    public DbSet<TipoServicio> TipoServicio { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reclamo>().ToTable("reclamo");
        modelBuilder.Entity<EstadoTicket>().ToTable("estadoticket");
        modelBuilder.Entity<PrioridadTicket>().ToTable("prioridadticket");
        modelBuilder.Entity<TipoServicio>().ToTable("tiposervicio");
    }
}
}