using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Escola_5SBD_ORM.Data.Converters
{
    public class DateOnlyEFConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyEFConverter() : base(
             d => d.ToDateTime(TimeOnly.MinValue),
             dt => DateOnly.FromDateTime(dt))
        { }
    }
}
