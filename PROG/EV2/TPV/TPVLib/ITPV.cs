namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }

        int GetProductsCount();
        Product GetProductWithId(long id);
        bool ContainsProduct(Product product);

		long AddProduct(Product product);
        void RemoveProduct(long Id);
        List<Product> GetProducts();

        void AddTicket(IDatabase database);
        void UpdateProductWithId(long Id, Product product);

        int ProductsCount { get; }

        Product GetProduct(long Id);
        List<Product> GetProducts(int offset, int limit);
    }
}