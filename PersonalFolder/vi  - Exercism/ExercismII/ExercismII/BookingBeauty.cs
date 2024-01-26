namespace ExercismII
{
    public class BookingBeauty
    {
        public static DateTime Schedule(string appointmentDateDescription)
        {
            int day = 1;
            int month = 1;
            int year = 2022;

            int hour = 10;
            int minute = 20;
            int second = 30;

            string date = appointmentDateDescription;
            //month = (int)(date[0] - '0');

            month = Int32.Parse(date.Substring(0, 1));
            day = Int32.Parse(date.Substring(2, 2));
            year = Int32.Parse(date.Substring(5, 4));

            hour = Int32.Parse(date.Substring(10, 2));
            minute = Int32.Parse(date.Substring(13, 2));
            second = Int32.Parse(date.Substring(16, 2));


            DateTime result = new DateTime(year, month, day, hour, minute, second);
            Console.WriteLine(result);
            Console.WriteLine(appointmentDateDescription);
            return result;
        }

        public static bool HasPassed(DateTime appointmentDate)
        {
            throw new NotImplementedException("Please implement the (static) Appointment.HasPassed() method");
        }

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            throw new NotImplementedException("Please implement the (static) Appointment.IsAfternoonAppointment() method");
        }

        public static string Description(DateTime appointmentDate)
        {
            throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
        }

        public static DateTime AnniversaryDate()
        {
            throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
        }
    }
}
