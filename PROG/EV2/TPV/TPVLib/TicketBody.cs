namespace TPVLib
{
    public class TicketBody
    {
        private TicketLine[] _ticketsLine;

        public TicketLine[] TicketsLine => ToArray();
        public TicketBody TicketBodyClone => Clone();
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
        public void AddSingleTicketLine(TicketLine ticket)
        {
            int count = _ticketsLine.Length;
            TicketLine[] result = new TicketLine[count + 1];
            for (int i = 0; i < count; i++)
            {
                result[i] = _ticketsLine[i];
            }
            result[count] = ticket;

            _ticketsLine = result;
        }
        public void AddSingleTicketLine(double quantity, string description, long id, Product product)
        {
            TicketLine ticketLine = new TicketLine();

            ticketLine.Quantity = quantity;
            ticketLine.Description = description;
            ticketLine.ID = id;
            ticketLine.Product = product;

            AddSingleTicketLine(ticketLine);
        }

        private TicketLine[] ToArray()
        {
            int count = _ticketsLine.Length;
            TicketLine[] copy = new TicketLine[count];
            
            for(int i = 0; i < count; i++)
            {
                copy[i] = _ticketsLine[i];
            }
            return copy;
        }

        private TicketBody Clone()
        {
            TicketBody clone = new TicketBody();
            for (int i = 0; i < _ticketsLine.Length; i++)
            {
                clone._ticketsLine[i] = _ticketsLine[i];
            }

            return clone;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE TICKETBODY.
        Esta clase añade el cuerpo del contenido a un objeto 'Ticket'.
        Cada body contiene cantidad, descripcion, id y Producto.
        
        |#| Ticket() {}
        |#| Ticket(numberLines) {TicketBody[] ticket = new TicketBody[numberLines]}

        + AddTicketLine(TicketLine[]) : void
        Añade un array de lineas de ticket.

        + AddSingleTicketLine(TicketLine) : void
        Añade una unica linea de ticket.
        
        + AddSingleTicketLine(quantity, description, id, Product) : void
        Añade una unica linea de ticket.

        - ToArray() : TicketLine
        Devuelve un array de ticketLine.

        - Clone() : TickeBody
        Clona un TicketBody para devolverlos de manera segura.
        */
        #endregion
    }
}
