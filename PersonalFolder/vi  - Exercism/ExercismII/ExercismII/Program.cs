namespace ExercismII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime result = BookingBeauty.Schedule(null);
            DateTime result1 = BookingBeauty.Schedule("7/25/2019 13:45:00");
            DateTime result2 = BookingBeauty.Schedule("July 25, 2019 13:45:00");
            DateTime result3 = BookingBeauty.Schedule("Thursday, July 25, 2019 13:45:00");

        }
    }
}