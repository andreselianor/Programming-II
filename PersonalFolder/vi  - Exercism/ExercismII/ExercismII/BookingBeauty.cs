namespace ExercismII
{
    public class BookingBeauty
    {
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public enum Month
        {
            Default,
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        public static DateTime Schedule(string appointmentDateDescription)
        {


            //"7/25/2019 13:45:00"
            //"July 25, 2019 13:45:00"
            //"Thursday, July 25, 2019 13:45:00"

            DateTime result;

            int sign = 0;
            for (int i = 0; i < appointmentDateDescription.Length; i++)
            {
                if (appointmentDateDescription[i] == ',')
                    sign++;
            }

            if (sign == 0)
                result = DateTimeOnlyNumber(appointmentDateDescription);
            else if (sign == 1)
                result = DateTimeWithMonth(appointmentDateDescription);
            else
                result = DateTimeWithDayWeek(appointmentDateDescription);

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

        public static DateTime DateTimeOnlyNumber(string appointmentDateDescription)
        {
            string appointment = appointmentDateDescription;
            if (appointment[1] == '/')
                appointment = appointment.Insert(0, "0");

            string month = appointment.Substring(0, 2);
            string day = appointment.Substring(3, 2);
            string year = appointment.Substring(6, 4);

            string hour = appointment.Substring(11, 2);
            string minute = appointment.Substring(14, 2);
            string second = appointment.Substring(17, 2);

            int monthInt = Int32.Parse(month);
            int yearInt = Int32.Parse(year);
            int dayInt = Int32.Parse(day);

            int hourInt = Int32.Parse(hour);
            int minuteInt = Int32.Parse(minute);
            int secondInt = Int32.Parse(second);

            DateTime date = new DateTime(yearInt, monthInt, dayInt, hourInt, minuteInt, secondInt);
            return date;
        }
        public static DateTime DateTimeWithMonth(string appointmentDateDescription)
        {
            char sign = ' ';
            int i = 0;
            string month = "";
            while (appointmentDateDescription[i] != sign)
            {
                month += appointmentDateDescription[i];
                i++;
            }

            string[] monthsName = Enum.GetNames<Month>();

            int monthResult = 0;
            for(int j = 0; j < 13; j++)
            {
                if (month == monthsName[j])
                    monthResult = j;
            }

            DateTime dateResult = new DateTime()

        }

        public static DateTime DateTimeWithDayWeek(string appointmentDateDescription)
        {
        }
    }
}
