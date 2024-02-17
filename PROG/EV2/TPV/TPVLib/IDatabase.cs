namespace TPVLib
{
    public interface IDatabase
    {
        int GetProductsCount();
        int IndexOf(int index);
        Product GetProductWithID(long ID);

        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void RemoveAt(int index);

        bool Contains(Product product);

        void Sort();
        void Filter();
        void Visit();

        string ToString();
        Product Clone();
    }
}
