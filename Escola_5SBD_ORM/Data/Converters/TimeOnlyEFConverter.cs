using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Escola_5SBD_ORM.Data.Converters
{
    public class TimeOnlyEFConverter : ValueConverter<TimeOnly, TimeSpan>
    {
        public TimeOnlyEFConverter() : base(
             t => t.ToTimeSpan(),
             ts => TimeOnly.FromTimeSpan(ts))
        { }
    }
}
