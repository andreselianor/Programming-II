using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11Torneo
{
    public enum Race
    {
        HUMANO,
        ALIEN,
        SPACEWARRIOR
    }
    abstract public class Persona
    {

        //Atributos
        //Como asignar valores predeterminados a un atributo?
        //Como asignar valores entre dos valores a un atributo?
        //Funcionan los getter y setter?

        private string _name = "";
        private Race _race;
        private double _energy;
        private double _dodgecapacity;

        //Properties
        public string Name => _name;
        public Race Race => _race;
        //public double Energy => _energy;
        //public double DodgeCapacity => _dodgecapacity;


        //Constructor
        public Persona(string name, Race race)
        {
            _name = name;
            _race = race;
            _energy = SetEnergy();

        }

        //Que metodo es mas optimo?
        public void SetDodgeCapacity()
        {
            Utils R = new Utils();
            double result = R.GetRandom(0.1, 0.9);
            _dodgecapacity = result;
        }

        public double SetEnergy()
        {
            Utils R = new Utils();
            double result = R.GetRandom(1000, 2000);
            return result;
        }

        //Metodos
        public double GetDefense()
        {
            Utils R1 = new Utils();
            return R1.GetRandom(0.1, 0.9);
        }

        public void SpendEnergy(double quantity)
        {
            _energy -= quantity;
        }

        abstract public void Attack(Persona p);


        abstract public double DefenseCapacity();


        abstract public double EludeCapacity();


        public bool CanElude()
        {
            Utils R1 = new Utils();
            double R = R1.GetRandom(0, 1);
            return R < _dodgecapacity;
        }


        //Herencia

        public class Humano : Persona
        {
            private double _handAttack;
            private double _defenseCapacity;
            private double _eludeCapacity;


            //Constructor
            public Humano(string name) : base(name, Race.HUMANO)
            {

            }

            protected Humano(string name, Race race) : base(name, Race.HUMANO)
            {

            }



            override public double EludeCapacity()
            {
                Utils R1 = new Utils();
                return R1.GetRandom(0.4, 0.6);

            }
            override public double DefenseCapacity()
            {
                Utils R1 = new Utils();
                return R1.GetRandom(0.7, 0.9);
            }

            public override void Attack(Persona p)
            {
                RemoveEnergy(1);
                if (attackGolpe < Random(0, 1))
                {
                    if`p.Quiereesquivar
                        se lo lleva
                    if p.Quiereparar
                        se lo lleva
                    se lo para
                }
            }

        }

        public class SpaceWarrior : Persona
        {
            SpaceWarrior(string name) : base(name, Race.SPACEWARRIOR)
            {

            }
            override public double EludeCapacity()
            {


                Utils R1 = new Utils();
                return R1.GetRandom(0.4, 0.6);

            }
            override public double DefenseCapacity()
            {
                Utils R1 = new Utils();
                return R1.GetRandom(0.7, 0.9);
            }

            override public void Attack(Persona p)
            {
                RemoveEnergy(1);
                if (attackGolpe < Random(0, 1))
                {
                    {
                        if`p.Quiereesquivar
                            se lo lleva
                        if p.Quiereparar
                        se lo lleva
                    se lo para
                    }
                }

            }
        }

    }
}
