using AutoMapper;
using Ticket.API.Converters;
using Ticket.API.DTO;
using Ticket.API.Entidades;

namespace Ticket.API.Profiles;

public class MappingProfile: Profile
{
     public MappingProfile()
    {
        // Configuraciones de mapeo
        CreateMap<Reclamo, ReclamoDTO>()
            .ForMember(dest => dest.FechaTicket, opt => opt.ConvertUsing(new FechaIntConverter(), src => src.FechaTicket));
    }
}

