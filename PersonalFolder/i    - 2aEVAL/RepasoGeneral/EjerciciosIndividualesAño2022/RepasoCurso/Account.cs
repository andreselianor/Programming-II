namespace RepasoCurso
{
    public class Account
    {
        private string _code;
        private string _owner;
        private double _quantity;

        public string Code => _code;
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        public double Quantity => _quantity;

        public Account()
        {

        }

        public Account(string code, string owner, double quantity)
        {
            _code = code;
            _owner = owner;
            _quantity = quantity;            
        }

        public void IngressQuantity(double quantity)
        {
            if (quantity < 0)
                return;
            _quantity += quantity;
        }

        public double RemoveQuantity(double quantity)
        {
            if (quantity < 0)
                return 0.0;
            if(_quantity - quantity < 0)
            {
                _quantity = 0;
                return _quantity - quantity;
            }
            _quantity -= quantity;
            return quantity;
        }

        public override string ToString()
        {
            return $"La cuenta de codigo {_code} con propietario {_owner}, contiene {_quantity}";
        }

        public Account Clone()
        {
            Account result = new Account();
            result._code = _code;
            result._owner = _owner;
            result._quantity = _quantity;
            return result;
        }
    }
}
