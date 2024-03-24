namespace TPVLib
{
    public class TicketLine
    {
        private string _description;
        private long _Id;
        private double _quantity;
        private Product _product;
        public string Description { get; set; }
        public long ID { get; set; }
        public double Quantity { get; set; }
        public Product Product { get; set; }

        public TicketLine() { }
        public TicketLine(string description, long id, double quantity, Product product)
        {            
            _description = description;
            _Id = id;
            _quantity = quantity;
            _product = product;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE TICKETLINE.
        Esta clase crea las lineas precio/producto que componen el ticket.
        Cada Linea contiene una descripcion, un id, una cantidad y un producto.
        
        |#| TicketHeader() {}
        |#| TicketHeader(description, id, quantity, Product) 
        {_description = description; _Id = id; _quantity = quantity; _product = product;}
        */
        #endregion
    }
}