using Microsoft.EntityFrameworkCore;
using Ticket.API.Repositorios;
using Ticket.API.Servicios;
using Ticket.API.Servicios.Interfaces;
using Ticket.API.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TicketAppContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("dbGestionDeTicket")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p =>p.AddPolicy("corsapp", builder =>{builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();}));

// Crea instancias automaticas de un repositorio// mapeo de interfaces F12
builder.Services.AddTransient<IReclamoRepositorio, ReclamoRepositorio>();
builder.Services.AddTransient<ITipoServicioRepositorio, TipoServicioRepositorio>();
builder.Services.AddTransient<IEstadoTicketRepositorio, EstadoTicketRepositorio>();
builder.Services.AddTransient<IPrioridadTicketRepositorio, PrioridadTicketRepositorio>();

builder.Services.AddTransient<IReclamoServicio, ReclamoServicio>();
builder.Services.AddTransient<ITipoServicioServicio, TipoServicioServicio>();
builder.Services.AddTransient<IEstadoTicketServicio, EstadoTicketServicio>();
builder.Services.AddTransient<IPrioridadTicketServicio, PrioridadTicketServicio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();


/*  "ConnectionStrings":{
    "dbGestionDeTicket": "Server=172.23.2.108;Database=GestionTickets;UserId=postgres;Password=redites;CommandTimeout=60"    
  }  */