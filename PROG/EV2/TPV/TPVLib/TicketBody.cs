namespace TPVLib
{
    public class TicketBody
    {
        private TicketLine[] _ticketsLine;

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
    }
}
