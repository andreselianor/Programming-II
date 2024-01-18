namespace CrazyCarsII
{
    public class Race
    {
        private double _distance;
        private bool _isWinner;

        private List<Car> _carList = new List<Car>();

        public Race(int distance)
        {
            _distance = distance;
        }

        public void InitRace()
        {
            Car c1;
            c1 = new GlamourCar();
            _carList.Add(c1);
            c1 = new WoodCar();
            _carList.Add(c1);
            c1 = new TroglodyteCar();
            _carList.Add(c1);
            c1 = new PierreCar();
            _carList.Add(c1);
        }

        public void ExecuteRace()
        {

            for (int i = 0; i < _carList.Count; i++)
            {
                _carList[i].Execute();
                _carList[i].Report();
            }

        }

        public bool IsWinner()
        {
            for (int i = 0; i < _carList.Count; i++)
            {
                if (_carList[i].Position >= _distance)
                    return true;
            }
            return false;
        }

        public List<Car> GetWinners()
        {
            List<Car> listWinners = new List<Car>();
            for (int i = 0; i < _carList.Count; i++)
            {
                if (_carList[i].Position >= _distance)
                    listWinners.Add(_carList[i]);
            }
            return listWinners;
        }
    }
}
