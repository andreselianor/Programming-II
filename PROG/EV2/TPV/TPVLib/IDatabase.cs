namespace TPVLib
{
    public interface IDatabase
    {
        void AddProduct(Product product);
        void AddTicketHeader(TicketHeader ticketHeader);
        void AddTicketLine(TicketLine ticketLine);

        int GetProductsCount();
        int IndexOf(Product product);
        Product GetProductAt(int index);

        void RemoveProduct();
        void RemoveProductAt(int index);

        bool Contains();

        void Filter();
        void Sort();
        void Visit();

        string ToString();
        Product Clone();
    }
}
