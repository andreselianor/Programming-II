namespace DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly d1 = BookingDate.OnlyDate();
            string result = BookingDate.OnlyDateFormat();
            int result2 = BookingDate.GetMonth();
        }
    }
}