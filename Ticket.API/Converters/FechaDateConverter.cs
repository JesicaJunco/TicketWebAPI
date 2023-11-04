using AutoMapper;
using NodaTime.Extensions;

namespace Ticket.API.Converters;

public class FechaDateConverter  : IValueConverter<int, DateTime>
{
    public DateTime Convert(int source, ResolutionContext context)
    {
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
        dateTime = dateTime.AddSeconds( source ).ToLocalTime();

      //  DateTime localTime = TimeZoneInfo.ConvertTime(dateTime, TimeZoneInfo.Local);
        return dateTime;
    }


}

   
