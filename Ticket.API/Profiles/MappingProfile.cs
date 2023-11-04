using AutoMapper;
using Ticket.API.Converters;
using Ticket.API.DTO;
using Ticket.API.Entidades;

namespace Ticket.API.Profiles;

public class MappingProfile: Profile
{
     public MappingProfile()
    {
        CreateMap<ReclamoRequest, Reclamo>();
        CreateMap<Reclamo, ReclamoResponse>()
            .ForMember(dest => dest.FechaTicket,  opt => opt.ConvertUsing(new FechaDateConverter(), src => src.FechaTicket));
    }
}

