using AutoMapper;

namespace Ticket.API.Converters;

public class FechaIntConverter  : IValueConverter<DateTime, int>
{
    private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    public int Convert(DateTime source, ResolutionContext context)
    {
        TimeSpan elapsedTime = source - Epoch;
        return  (int) elapsedTime.TotalSeconds;
    }

}

   
