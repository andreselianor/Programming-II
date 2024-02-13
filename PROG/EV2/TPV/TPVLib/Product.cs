namespace TPVLib
{
    public enum IvaType
    {
        GENERAL,
        REDUCIDO,
        SUPERREDUCIDO,
        NINGUNO,
        DEFAULT
    }

    public class Product
    {
        private long _ID;
        private string _name;
        private string _description;
        private string _image;
        private bool _available;
        private int _stock;
        private double _price;
        private IvaType _ivaType;

        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Available { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public IvaType IvaType { get; set; }
    }
}