namespace RepasoCurso
{
    public class CoffeMachine
    {
        public enum CoffeState
        {
            FULL,
            HALF,
            EMPTY
        }

        private double _maxCapacity;
        private double _actualCapacity;
        private CoffeState _state;

        public double MaxCapacity => _maxCapacity;
        public double ActualCapacity => _actualCapacity;
        public CoffeState State => _state;

        public CoffeMachine()
        {
            _maxCapacity = 1000.0;
            _actualCapacity = 0.0;
        }

        public CoffeMachine(double MaxCapacity)
        {
            _maxCapacity = MaxCapacity;
            _actualCapacity = _maxCapacity;
        }

        public CoffeMachine(double maxCapacity, double actualCapacity)
        {
            _maxCapacity = maxCapacity;
            if (actualCapacity > _maxCapacity)
            {
                _actualCapacity = _maxCapacity;
            }
            else
            {
                _actualCapacity = actualCapacity;
            }
        }

        public void EmptyCoffeMachine()
        {
            _actualCapacity = 0;
        }

        public void UseCoffeMachine(double value)
        {
            if (value < 0)
                return;

            if (value > _actualCapacity)
            {
                _actualCapacity = 0;
            }
            else
            {
                _actualCapacity -= value;
            }
        }

        public void AddCoffee(double value)
        {
            if (value < 0)
                return;
            if (value + _actualCapacity > _maxCapacity)
            {
                _actualCapacity = _maxCapacity;
            }
            else
            {
                _actualCapacity += value;
            }
        }

        public CoffeState GetState()
        {
            if (_actualCapacity == _maxCapacity)
                return CoffeState.FULL;
            if (_actualCapacity == 0)
                return CoffeState.EMPTY;

            return CoffeState.HALF;
        }

        private CoffeMachine Clone()
        {
            CoffeMachine coffeResult = new CoffeMachine();

            coffeResult._maxCapacity = this._maxCapacity;
            coffeResult._actualCapacity = this._actualCapacity;

            return coffeResult;
        }
    }
}