using AutoMapper;

namespace Ticket.API.Converters;

public class FechaIntConverter  : IValueConverter<int, DateTime>
{
    public DateTime Convert(int source, ResolutionContext context)
    {
        // Suponiendo que la fecha está en el formato YYYYMMDD
        int year = source / 10000;
        int month = (source % 10000) / 100;
        int day = source % 100;
        
        return new DateTime(year, month, day);
    }

}

   
