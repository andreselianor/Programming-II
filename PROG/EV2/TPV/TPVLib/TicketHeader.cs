namespace TPVLib
{
    public class TicketHeader
    {
        private DateTime _date;
        private int _barCode;

        public DateTime Date { get; set; }
        public int BarCode { get; set; }

        public TicketHeader() { }

        public TicketHeader(DateTime date, int barCode)
        {
            _date = date;
            _barCode = barCode;
        }
    }
}
