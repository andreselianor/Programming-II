namespace FarmRevisited
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        private int _hour;
        private int _minute;
        private int _second;

        public Date()
        {

        }
        public Date(int year, int month, int day, int hour, int minute, int second)
        {
            _year = year;
            _month = month;
            _day = day;
            _hour = hour;
            _minute = minute;
            _second = second;
        }

        public int Year => _year;
        public int Month => _month;
        public int Day => _day;
        public int Hour => _hour;
        public int Minute => _minute;
        public int Second => _second;
    }
}
