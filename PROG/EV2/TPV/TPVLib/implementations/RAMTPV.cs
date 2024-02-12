namespace TPVLib
{
    internal class RAMTPV : ITPV
    {
		private List<Product> _listProducts = new List<Product>();
		
		public long AddProduct(Product product)
		{
			if(product == null)
				return 0;
			
			if(_listProducts.Contains(product)
				return -1;
			
			_listProducts.Add(product);
			return product.ID;
		}
    }
}