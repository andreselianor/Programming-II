namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewITPV()
        {
            return new RAMTPV();
        }
		
		long AddProduct(Product product);
    }
}
