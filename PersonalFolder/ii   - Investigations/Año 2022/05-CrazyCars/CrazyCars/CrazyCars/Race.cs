namespace CrazyCars
{
    public class Race : IRace
    {
        private double _raceLength;
        private List<RaceObject> _raceObjectList = new List<RaceObject>();

        public int GetObjectsCount()
        {
            return _raceObjectList.Count;
        }

        public RaceObject GetRaceObjectAt(int index)
        {
            return _raceObjectList[index];
        }

        public void Init(double distance)
        {
            _raceLength = distance;

            GlamourCar car1 = new GlamourCar("Phoebe");
            _raceObjectList.Add(car1);

            WoodCar car2 = new WoodCar("Leño");
            _raceObjectList.Add(car2);

            PierreCar car3 = new PierreCar("LeGrand");
            _raceObjectList.Add(car3);

            TroglodyteCar car4 = new TroglodyteCar("ZeemanWeeman");
            _raceObjectList.Add(car4);

            Rock obstacle1 = new Rock();
            _raceObjectList.Add(obstacle1);

            Lagoon obstacle2 = new Lagoon();
            _raceObjectList.Add(obstacle2);

            Bomb obstacle3 = new Bomb();
            _raceObjectList.Add(obstacle3);
        }

        public void PrintRacers()
        {
            foreach(var item in _raceObjectList)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ObjectType);
                Console.WriteLine(item.Position);
                Console.WriteLine(item.IsEnabled);
                Console.WriteLine(item.NumberTurnsDisabled);
                Console.WriteLine("***");
            }
        }

        public List<RaceObject> Simulate(IRace race)
        {
            bool winner = false;

            while (!winner)
            {
                for(int i = 0; i < _raceObjectList.Count; i++)
                {
                    _raceObjectList[i].Simulate(race);
                }

                winner = IsWinner();                
            }

            PrintWinner();
            return _raceObjectList;
        }

        public bool IsWinner()
        {
            for(int i = 0; i < _raceObjectList.Count; i++)
            {
                RaceObject element = new RaceObject();
                element = GetRaceObjectAt(i);
                if (element.Position >= _raceLength)
                    return true;
            }
            return false;
        }

        public void PrintWinner()
        {
            for (int i = 0; i < _raceObjectList.Count; i++)
            {
                RaceObject element = new RaceObject();
                element = GetRaceObjectAt(i);
                if (element.Position >= _raceLength)
                    Console.WriteLine(String.Format("El ganador es: {0}", element.Name));
            }
        }
    }
}
