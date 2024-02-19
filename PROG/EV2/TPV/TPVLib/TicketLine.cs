namespace TPVLib
{
    public class TicketLine
    {
        private string _description;
        private long _Id;
        private int _quantity;
        private Product _product;

        public string Description { get; set; }
        public long ID { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public TicketLine() { }
        public TicketLine(string description, long id, int quantity, Product product)
        {
            _description = description;
            _Id = id;
            _quantity = quantity;
            _product = product;
        }
    }
}