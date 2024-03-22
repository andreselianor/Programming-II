using System.Dynamic;

namespace RepasoCurso
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date()
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public int Year => _year;
        public int Month
        {
            get
            {
                if (_month < 1)
                    _month = 1;
                else if (_month > 12)
                    _month = 12;
                return _month;
            }
        }
        public int Day
        {
            get
            {
                if (_day < 1)
                    _day = 1;
                else if (_day > 31)
                    _day = 12;
                return _day;
            }
        }

        public void IsLeapYear()
        {

        }

        public int GetDaysoftheMonth()
        {
            return MonthsDay(_month);
        }
        public static int GetDaysoftheMonth(int month)
        {
            return MonthsDayStatic(month);
        }

        private int MonthsDay(int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28;
                default:
                    return -1;
            }
        }

        private static int MonthsDayStatic(int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28;
                default:
                    return -1;
            }
        }
    }
}