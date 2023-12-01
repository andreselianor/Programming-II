namespace Jar_Datetime_BigNumbers
{
    public class Jar
    {
        private double _capacity;
        private double _quantity;

        public double SetQuantity(double value)
        {
            if (value < 0)
                _quantity = 0;

            _quantity = value;

            if (_quantity > _capacity)
            {
                _quantity = _capacity;
                return (value - _quantity);
            }
            return 0;
        }

        public double GetQuantity()
        {
            return _quantity;
        }

        public void SetCapacity(double value)
        {
            if (value < 0)
                _capacity = 0;

            if (_quantity > _capacity)
                _capacity = _quantity;
            else
                _capacity = value;
        }

        public double GetCapacity()
        {
            return _capacity;
        }
        public double GetPercent()
        {
            if (_capacity == 0)
                return double.NaN;

            return _quantity / _capacity;
        }

        public double GetRemain()
        {
            return (_capacity - _quantity);
        }

        public double AddQuantity(double value)
        {
            if (value < 0)
                _quantity = 0;

            _quantity += value;

            double remaining;
            if (_quantity > _capacity)
            {
                remaining = _quantity - _capacity;
                _quantity = _capacity;
            }
            else
            {
                remaining = _capacity - _quantity;
            }

            return remaining;
        }
    }
}

