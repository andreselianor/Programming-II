namespace TPVLib
{
    public class TicketBody
    {
        private TicketLine[] _ticketsLine;

        public TicketLine[] TicketsLine => this.Clone();
        public TicketBody()
        {
            _ticketsLine = new TicketLine[0];
        }
        public TicketBody(int numberLines)
        {
            _ticketsLine = new TicketLine[numberLines];
        }

        public void AddTicketLine(TicketLine[] ticketLine)
        {
            if (ticketLine == null)
                return;

            for (int i = 0; i < _ticketsLine.Length; i++)
            {
                _ticketsLine[i] = ticketLine[i];
            }
        }

        public TicketLine[] Clone()
        {
            int count = _ticketsLine.Length;
            TicketLine[] clone = new TicketLine[count];
            
            for(int i = 0; i < count; i++)
            {
                clone[i] = _ticketsLine[i];
            }
            return clone;
        }
    }
}
