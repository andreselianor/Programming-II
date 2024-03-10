namespace TPVLib
{
    public interface IDatabase
    {
        long AddProduct(Product product);
        void AddTicket();
        void AddTicketHeader(TicketHeader ticketHeader);
        void AddTicketLine(TicketLine ticketLine);
        void AddTicketBody(TicketLine[] ticketLines);

        void RemoveProduct(Product product);
        void RemoveProductWithId(long Id);
        void RemoveTicket(Ticket ticket);
    }
}