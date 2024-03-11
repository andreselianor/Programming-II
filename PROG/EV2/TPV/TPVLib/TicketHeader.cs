namespace TPVLib
{
    public class TicketHeader
    {
        private DateTime _date;
        private int _barCode;
        public DateTime Date { get; set; }
        public int Barcode { get; set; }

        public TicketHeader() { }
        public TicketHeader(DateTime date, int barcode)
        {
            _date = date;
            _barCode = barcode;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE TICKETHEADER.
        Esta clase crea instancias de tipo cabecera de ticket.
        Cada Header contiene una fecha y un codigo de barras.
        
        |#| TicketHeader() {}
        |#| TicketHeader(date, barcode) {_date = date; _barCode = barcode;}
        */
        #endregion
    }
}
