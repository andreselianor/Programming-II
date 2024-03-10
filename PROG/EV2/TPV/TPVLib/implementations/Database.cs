using System.Net.Sockets;

namespace TPVLib.implementations
{
    public class Database : IDatabase
    {
        private List<Product> _listProducts = new List<Product>();
        private List<Ticket> _listTickets = new List<Ticket>();
        private Ticket _ticket = new Ticket();

        public void AddTicket()
        {
            Ticket ticket = new Ticket();
            _listTickets.Add(ticket);
        }
        public long AddProduct(Product product)
        {
            if (product == null)
                return 0;

            _listProducts.Add(product);
            return product.ID;
        }

        public void AddTicketBody(TicketLine[] ticketLines)
        {
            if (ticketLines == null)
                return;

            _ticket.AddTicketBody(ticketLines);
        }

        public void AddTicketHeader(TicketHeader ticketHeader)
        {
            if (ticketHeader == null)
                return;

            _ticket.AddTicketHeader(ticketHeader.Barcode);
        }

        public void AddTicketLine(TicketLine ticketLine)
        {
            if (ticketLine == null)
                return;

            TicketBody ticketBody = new TicketBody();
            ticketBody.AddSingleTicketLine(ticketLine.Quantity, ticketLine.Description, ticketLine.ID, ticketLine.Product);
        }

        public void RemoveProduct(Product product)
        {
            if (product == null)
                return;

            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (_listProducts[i] == product)
                    _listProducts.Remove(product);
            }
        }

        public void RemoveProductWithId(long Id)
        {
            if (Id == 0)
                return;

            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (_listProducts[i].ID == Id)
                    _listProducts.RemoveAt(i);
            }
        }

        public void RemoveTicket(Ticket ticket)
        {
            if (ticket == null)
                return;

            for (int i = 0; i < _listTickets.Count; i++)
            {
                if (_listTickets[i] == ticket)
                    _listTickets.Remove(ticket);
            }
        }
    }
}