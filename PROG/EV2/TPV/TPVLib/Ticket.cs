namespace TPVLib
{
    public class Ticket
    {
        private TicketHeader _ticketHeader;
        private TicketBody _ticketBody;
        private double _price;

        public Ticket()
        {
            _ticketHeader = new TicketHeader();
            _ticketBody = new TicketBody();
        }

        public Ticket(TicketHeader ticketHeader, TicketBody ticketBody)
        {
            _ticketHeader = ticketHeader;
            _ticketBody = ticketBody;
        }

        public TicketHeader AddTicketHeader(int barcode)
        {
            //TicketHeader ticket = new TicketHeader(DateTime.Now, barcode);
            TicketHeader ticket = new TicketHeader();

            ticket.Date = DateTime.Now;
            ticket.BarCode = barcode;
            return ticket;
        }

        public TicketBody AddTicketBody(TicketLine[] ticketsLine)
        {
            TicketBody ticket = new TicketBody();
            ticket.AddTicketLine(ticketsLine);
            return ticket;
        }

        public TicketLine AddTicketLine(double quantity, string description, long id, Product product)
        {
            TicketLine ticket = new TicketLine();

            ticket.Quantity = quantity;
            ticket.Description = description;
            ticket.ID = id;
            ticket.Product = product;

            return new TicketLine();
        }

        public void SetPrice(double value)
        {
            _price = value;
        }
    }
}
