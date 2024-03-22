namespace AutosLocos
{
    public class Pierre : Car
    {
        private int _tramps;
        public Pierre() { }
        public Pierre(string name, ObjectType type) : base(name, type)
        {
            SetInitTramps();
        }
        public override void Simulate(IRace race)
        {           
            if (_disabledTurns < 1)
            {
                _position += 18.0 + FineTunning;
                SetTramp(race);
            }                

            if (_disabledTurns > 0)
                _disabledTurns -= 1;
        }

        private void SetInitTramps()
        {
            _tramps = (int)(Utils.GetRandom() * 10 + 10);
        }

        private void SetTramp(IRace race)
        {
            double chance = Utils.GetRandom();
            if (chance < 0.5)
                PierreTrampPosterior(race);
        }

        private void PierreTrampPosterior(IRace race)
        {
            List<Car> runners = race.Sort();
            int position = GetPierre(runners);
            SetTrampPosterior(position, runners);
        }

        private int GetPierre(List<Car> runners)
        {
            for (int i = 0; i < runners.Count; i++)
            {
                if (runners[i].Type == ObjectType.PIERRECAR)
                    return i;
            }
            return -1;
        }

        private void SetTrampPosterior(int position, List<Car> runners)
        {
            if (runners[0].Type == ObjectType.PIERRECAR)
                return;
            else
            {
                Car car = runners[position - 1];
                double chance = Utils.GetRandom();
                if (chance < 0.3)
                    car.SetDisabledTurns(1);
                else
                    RisitasDropDown();
            }
            
        }

        private void RisitasDropDown()
        {

        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE PIERRE · PILOTO DE CARRERA

        + GetVelocityExtra : double
        Devuelve un valor entero random entre -1.0 y 3.0.

        */
        #endregion
    }
}
