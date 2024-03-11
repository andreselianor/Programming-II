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

        public void AddTicketHeader(int barcode)
        {
            if (barcode < 0 || barcode > int.MaxValue)
                return;
            TicketHeader ticket = new TicketHeader(DateTime.Now, barcode);

            //TicketHeader ticketAlternative = new TicketHeader();
            //ticket.Date = DateTime.Now;
            //ticket.BarCode = barcode;

            _ticketHeader = ticket;
        }
        public void AddTicketBody(TicketLine[] ticketsLine)
        {
            if (ticketsLine == null)
                return;

            TicketBody ticketBody = new TicketBody();
            ticketBody.AddTicketLine(ticketsLine);
            _ticketBody = ticketBody;
        }          
        public void AddTicketLine(TicketLine ticketLine)
        {
            if (ticketLine == null)
                return;

            TicketBody ticketResult = new TicketBody();
            ticketResult.AddSingleTicketLine(ticketLine);
            _ticketBody = ticketResult;
        }

        public void SetPrice(double value)
        {
            if (value < 0 || value > double.MaxValue)
                return;
            _price = value;
        }
        public double GetPrice()
        {
            return _price;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE CONTROLLER · MODELO - VISTA - CONTROLADOR DE UNA APLICACION.
        El controlador se encarga de relacionar los datos de la coleccion del modelo, 
        con la interfaz grafica del usuario.
        
        |#| Ticket() {}
        |#| Ticket(TicketHeader, TicketBody) {}

        + AddTicketHeader(barcode) : Ticket
        Esta funcion añade la cabecera del ticket. Se compone de fecha y codigo de barras.

        + AddTicketBody(TicketLine[]) : void
        Esta funcion añade las lineas de cada ticket. Se compone de objetos 'TicketLine'

        + SetPrice(value) : void
        Esta funcion establece el precio total de cada Ticket.

        + GetPrice(value) : void
        Esta funcion devuelve el precio total de cada Ticket.
        
        */
        #endregion
    }
}
