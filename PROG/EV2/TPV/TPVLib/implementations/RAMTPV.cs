namespace TPVLib
{
    internal class RAMTPV : ITPV
    {
        private List<Product> _listProducts = new List<Product>();


        public int ProductCount => _listProducts.Count;
        public bool IsEmpty => _listProducts.Count < 0;

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

            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (Id == _listProducts[i].ID)
                    return _listProducts[i];
            }
            return null;

            // Importante AÑADIR EL CLONE
            // TAMBIEN SE PUEDE AÑADIR UN FILTER, PERO NO FUNCIONAN EN LAS BBDD
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

        private void Clear()
        {
            _listProducts = new List<Product>();
        }

        private List<Product> Clone()
        {
            List<Product> cloneList = new List<Product>();
            cloneList = _listProducts;
            return cloneList;
        }
    }
}