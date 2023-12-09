namespace CrazyCars
{
    public enum ObjectType
    {
        GLAMOURCAR,
        TROGLODYTECAR,
        WOODCAR,
        PIERRECAR,
        ROCK,
        LAGOON,
        BOMB
    }
    public class RaceObject
    {
        private string _name = "";
        private double _position;
        private bool _isEnabled;
        private ObjectType _objectType;
        private int _numberTurnsDisabled;


        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }  
        }
        public ObjectType ObjectType
        {
            get { return _objectType; }
            set { _objectType = value; }
        }
        public double Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { _isEnabled = value; }
        }
        public int NumberTurnsDisabled
        {
            get { return _numberTurnsDisabled; }
            set { _numberTurnsDisabled = value; }
        }
        #endregion

        public RaceObject()
        {
            _isEnabled = true;
            _numberTurnsDisabled = 0;
        }

        public void Disabled(int turns)
        {
            _isEnabled = false;
            _numberTurnsDisabled = turns;
        }

        public virtual void Simulate(IRace race)
        {

        }
    }
}
