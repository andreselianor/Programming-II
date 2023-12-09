namespace Classes
{
    public enum GetDayOfWeek
    {
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
        SUNDAY
    }

    public class Datetime
    {
        private int _day;
        private int _month;
        private int _year;
        private int _second;
        private int _minutes;
        private int _hour; 
        

        #region Constructores
        public Datetime()
        {

        }

        public Datetime(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public Datetime(int day, int month, int year, int second, int minutes, int hour)
        {
            _day = day;
            _month = month;
            _year = year;
            _second = second;
            _minutes = minutes;
            _hour = hour;
        }
        #endregion

        #region Properties
        public int Day => _day;
        public int Month => _month;
        public int Year => _year;
        public int Second => _second;
        public int Minutes => _minutes;
        public int Hour => _hour;
        #endregion


        public Datetime Clone(Datetime datetime)
        {
            Datetime datetimeResult = new Datetime();
            _day = datetime.Day;
            _month = datetime.Month;
            _year = datetime.Year;
            _second = datetime.Second;
            _minutes = datetime.Minutes;
            _hour = datetime.Hour;

            return datetime;
        }

        public Datetime Clone2()
        {
            Datetime datetime = new Datetime(_day,_month,_year,_second,_minutes,_hour);
            return datetime;
        }

        public bool Equals(Datetime datetime)
        {
            if (this._day == datetime._day &&
                this._month == datetime._month &&
                this._year == datetime._year &&
                this._second == datetime._second &&
                this._minutes == datetime._minutes &&
                this._hour == datetime._hour)
                return true;
            return false;
        }

        public bool IsValid()
        {
            if (_day < 1 || _day > 32)
                return false;

            if (_month < 1 || _month > 13)
                return false;

            if (_year < 1970)
                return false;

            if (_second < 0 || _second > 60)
                return false;

            if (_minutes < 0 || _minutes > 60)
                return false;

            if (_hour < 0 || _hour > 24)
                return false;

            return true;
        }

        // Javi: No se puede hacer en una linea?
        public bool IsLeap()
        {
            if (_year % 4 == 0)
            {
                if (_year % 100 == 0)
                    return false;
                else if (_year % 400 == 0)
                    return true;
            }
            return false;
        }

        // Javi: No se puede hacer en una línea
        public static bool IsLeap(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                    return false;
                else if (year % 400 == 0)
                    return true;
            }
            return false;
        }

        override public string ToString()
        {
            return "" + _hour + ":" + _minutes + " " + _day + " " + _month + " " + _year;
        }

        // Javi: Otra vez, ..., función duplicada
        public static int GetDaysCount(int year, int month)
        {
            if (month == 1 ||
                month == 3 ||
                month == 5 ||
                month == 7 ||
                month == 8 ||
                month == 10 ||
                month == 11)
                return 31;

            if (month == 4 ||
                month == 6 ||
                month == 9 ||
                month == 11)
                return 30;

            if (month == 2 && IsLeap(year))
                return 29;
            else
                return 28;
        }

        public static int GetDaysCountAlt(int year, int month)
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
                    if (IsLeap(year))
                        return 29;
                    return 28;
            }
            return 0;
        }

        public void Incrementday()
        {
            if (_month == 1 && _day == 31)
            {
                _month = 2;
                _day = 1;
            }

            else if (_month == 3 && _day == 31)
            {
                _month = 4;
                _day = 1;
            }

            else
            {
                _day++;
            }
        }

        public void IncrementSeconds()
        {
            if (_second == 60)
            {
                _second = 0;
                _minutes++;
            }
            else
            {
                _second++;
            }
            // Javi:  incompleto, ..., y si los minutos pasan de 660?
        }

        public void GetDayOfWeek()
        {
            /* https://www.almanac.com/how-find-day-week */
            int lastDigits = Utils.LastDigits(_year);
        }        
    }
}
