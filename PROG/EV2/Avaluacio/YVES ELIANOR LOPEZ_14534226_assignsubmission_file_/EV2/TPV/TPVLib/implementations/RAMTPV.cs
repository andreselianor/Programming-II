namespace TPVLib
{
    internal class RAMTPV : ITPV
    {
        private List<Product> _listProducts = new List<Product>();
        private List<Ticket> _listTickets = new List<Ticket>();

        public int ProductsCount => _listProducts.Count;
        public bool IsEmpty => _listProducts.Count < 0;

        public RAMTPV()
        {
            CreateDataBase();
        }

        public long AddProduct(Product product)
        {
            if (product == null)
                return 0;
            if (_listProducts.Contains(product))
                return 0;

            _listProducts.Add(product);
            return product.ID;
        }
        public void RemoveProduct(long Id)
        {
            if (Id <= 0)
                return;

            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (Id == _listProducts[i].ID)
                    _listProducts.RemoveAt(i);
            }
        }
        public Product GetProduct(long Id)
        {
            if (Id <= 0)
                return null;

            Product clone = new Product();
            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (Id == _listProducts[i].ID)
                {                    
                    clone = _listProducts[i];
                    return clone;
                }
            }
            return null;
        }
        public void UpdateProductWithId(long Id, Product product)
        {
            if (Id <= 0 || product == null)
                return;

            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (Id == _listProducts[i].ID)
                    _listProducts[i] = product;
            }
        }
        public List<Product> GetProducts()
        {
            List<Product> cloneList = new List<Product>();

            for (int i = 0; i < _listProducts.Count; i++)
            {
                cloneList.Add(_listProducts[i]);
            }
            return cloneList;
        }
        public List<Product> GetProducts(int offset, int limit)
        {
            if (offset <= 0 || limit <= 0)
                return null;

            List<Product> cloneList = new List<Product>();

            for (int i = offset; i < limit; i++)
            {
                cloneList.Add(_listProducts[i]);
            }
            return cloneList;
        }
        public bool ContainsProduct(Product product)
        {
            if (product == null)
                return false;

            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (_listProducts[i].Equals(product))
                    return true;
            }
            return false;
        }

        private List<Product> Clone()
        {
            List<Product> cloneList = new List<Product>();
            for (int i = 0; i < _listProducts.Count; i++)
            {
                cloneList[i] = _listProducts[i];
            }            
            return cloneList;
        }

        private void CreateDataBase()
        {
            Product p1 = new Product();
            p1.Name = "Monoplaza 30minutos";
            _listProducts.Add(p1);

            Product p2 = new Product();
            p2.Name = "Monoplaza 60minutos";
            _listProducts.Add(p2);

            Product p3 = new Product();
            p3.Name = "Speedster 30minutos";
            _listProducts.Add(p3);

            Product p4 = new Product();
            p4.Name = "Speedster 30minutos";
            _listProducts.Add(p4);

            Product p5 = new Product();
            p5.Name = "KartTwin 30minutos";
            _listProducts.Add(p5);

            Product p6 = new Product();
            p6.Name = "KartTwin 60minutos";
            _listProducts.Add(p6);
        }

        public Ticket AddTicket(int barcode, TicketLine[] ticketsLine, double price)
        {
            Ticket ticketResult = new Ticket();

            ticketResult.AddTicketHeader(barcode);
            ticketResult.AddTicketBody(ticketsLine);
            ticketResult.SetPrice(price);

            return ticketResult;
        }

        public int GetProductsCount()
        {
            return _listProducts.Count;
        }

        public Product GetProductWithId(long id)
        {
            for(int i = 0; i < _listProducts.Count;i++)
            {
                if (_listProducts[i].ID == id)
                    return _listProducts[i];
            }
            return null;
        }

        public void AddTicket(IDatabase database)
        {
            database.AddTicket();
        }
        public void Clear()
        {
            _listProducts = new List<Product>();
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE RAMTPV.
        Esta clase contiene las funciones generales. Es en la clase Database donde se implementan 
        de manera mas concreta.

        (P) ProductsCount
        (P) IsEmpty

        |#| RAMTPV(){CreateDatabase()} => Es una alternativa a la funcion static 'CreateNewTPV()'
        de la interfaz ITPV.

        + AddProduct(Product) : long
        Añade un producto.

        + RemoveProduct(Id) : void
        Elimina un producto.

        + GetProduct(Id) : Product
        Recupera un producto.

        + UpdateProductWithId(Id, Product) : void 
        Actualiza un producto.

        + GetProducts() : List<Product> 
        Devuelve una copia de la lista de productos.

        + GetProducts(int offset, int limit) : List<Product>
        Devuelve una lista de n productos a partir de un indice.

        + ContainsProduct(Product) : bool
        Devuelve verdadero o false si la coleccion contiene un producto.
        
        - Clone() : List<Product> 
        Clona la lista de productos.

        + CreateDatabase() : void
        Crea los elementos que forman la base de datos y los añade a la lista.

        + AddTicket(int barcode, TicketLine[] ticketsLine, double price) : Ticket
        Crea un ticket nuevo.

        + GetProductsCount() : int
        Devuelve el numero de elementos dentro de la lista.

        + GetProductWithId(ID) : Product
        Devuelve el producto que tiene un ID especifico.

        + AddTicket(IDatabase) : void
        Añade un ticket utilizando las funciones propias de la interfaz IDatabase
        
        + Clear() : void
        Elimina todos los elementos de la base de datos.
        */
        #endregion
    }
}