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

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE DATABASE.
        El modelo contiene la coleccion de funciones que manejan los elementos del programa.
        
        + AddTicket() : void
        Añade un ticket a la lista de tickets.

        + AddProduct(Product) : long
        Añade un producto. Devuelve el identificador del producto.

        + AddTicketBody(TicketBody) : void
        Añade el cuerpo del ticket.

        + AddTicketHeader(TicketHeader) : void
        Añade la cabecera del ticket.

        + AddTicketLine(TicketLine) : void
        Añade una linea al ticket.

        + RemoveProduct(Product) : void
        Elimina un producto del ticket.

        + RemoveProductWithId(ID) : void
        Elimina un producto con un identificador especifico.

        + RemoveTicket(Ticket) : void
        Elimina un ticket de la lista.
        */
        #endregion
    }
}