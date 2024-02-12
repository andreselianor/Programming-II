namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewITPV()
        {
            return new RAMTPV();
        }
		
		long AddProduct(Product product);
        void RemoveProduct(long Id);
        Product GetProduct(long Id);

        void UpdateProductWithId(long Id, Product product);

        int ProductCount { get; }
        List<Product> GetProducts(int offset, int limit);
    }
}
