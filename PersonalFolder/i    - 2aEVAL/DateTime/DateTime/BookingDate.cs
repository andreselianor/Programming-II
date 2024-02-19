using System.Globalization;

namespace DateTime
{
    public enum TypeMonth
    {
        JANUARY = 0,
        FEBRUARY = 1
    }

    public class BookingDate
    {
        public static DateOnly OnlyDate()
        {
            DateOnly date1 = new DateOnly(1983,03,24);

            return date1;
        }

        public static string OnlyDateFormat()
        {
            DateOnly date1 = new DateOnly(1983, 03, 24);

            string diaSemana = date1.DayOfWeek.ToString();
            return "" + date1.Year + date1.Month + date1.Day + diaSemana;
        }

        public static string GetMonth()
        {
            return TypeMonth.JANUARY.ToString();
        }

        
    }
}
