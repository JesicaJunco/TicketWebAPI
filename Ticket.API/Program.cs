using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Ticket.API.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TicketAppContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Ticket")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Crea instancias automaticas de un repositorio// mapeo de interfaces F12
builder.Services.AddScoped<IReclamoRepositorio, ReclamoRepositorio>();
builder.Services.AddScoped<ITipoServicioRepositorio, TipoServicioRepositorio>();
builder.Services.AddScoped<IEstadoTicketRepositorio, EstadoTicketRepositorio>();
builder.Services.AddScoped<IPrioridadTicketRepositorio, PrioridadTicketRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
