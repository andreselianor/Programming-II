namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }
		
		long AddProduct(Product product);
        void RemoveProduct(long Id);
        Product GetProduct(long Id);
        List<Product> GetProducts();

        void UpdateProductWithId(long Id, Product product);

        int ProductsCount { get; }
        List<Product> GetProducts(int offset, int limit);
    }
}
