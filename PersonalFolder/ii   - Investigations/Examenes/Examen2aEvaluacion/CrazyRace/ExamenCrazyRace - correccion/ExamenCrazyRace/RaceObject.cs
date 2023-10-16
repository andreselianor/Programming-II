using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCrazyRace
{
    public enum ObjectType
    {
        ROCK,
        CHARCO,
        BOMB,
        CAR,
        GLAMOURCAR,
        TROGLODYTECAR,
        WOODCAR,
        PIERECAR
    }

    public abstract class RaceObject
    {
        private string _name;
        private int _position;

        public string Name
        {
            get { return _name; }
        }

        public int Position
        {
            get { return _position; }
        }


        // CONSTRUCTOR DE RACEOBJECT
        public RaceObject(string name, int position)
        {
            _name = name;
            _position = position;
        }

        //METODOS

        public abstract ObjectType GetObjectType();

        public abstract bool IsEnabled();

        public void Disable(int turns)
        {

        }
        public void Simulate(IRace Carrera)
        {
            //Carrera.Iniciar(1000);
        }
    }

    //CLASE ABSTRACTA OBSTACLE

    public abstract class Obstacle : RaceObject
    {
        public Obstacle(string name, int position) : base(name, position)
        {

        }
    }

    public class Rock : Obstacle
    {
        private int _weight;

        public override ObjectType GetObjectType()
        {
            return ObjectType.ROCK;
        }

        public override bool IsEnabled()
        {
            return true;
        }

        public Rock(string name, int position, int weight) : base(name, position)
        {
            _weight = weight;
        }

        //METODO DE ROCK

    }

    public class Charco : Obstacle
    {


        public override ObjectType GetObjectType()
        {
            return ObjectType.CHARCO;
        }

        public override bool IsEnabled()
        {
            return true;
        }

        public Charco(string name, int position) : base(name, position)
        {

        }


    }

    public class Bomb : Obstacle
    {

        public override ObjectType GetObjectType()
        {
            return ObjectType.BOMB;
        }

        public override bool IsEnabled()
        {
            return true;
        }

        public Bomb(string name, int position, int turns) : base(name, position)
        {

        }
    }

    public abstract class Car : RaceObject
    {
        protected int _fineTunning;


        // El metodo Tunning es un intento de metodo virtual que se complementa en cada una de las clases hijas de Car.
        // Al final he decidido generar el valor RANDOM en la clase RACE, justo antes de utilizar el constructor de cada participante de la carrera.
        public virtual int Tunning()
        {
           return Utils.GetRandomReal(1, 3);
        }

        public Car(string name, int position, int tunning) : base(name, position)
        {
            _fineTunning = tunning;
        }

    }

    public class GlamourCar : Car
    {
        private int _position;

        public GlamourCar(string name, int position, int tunning) : base(name, position, tunning)
        {
                        
        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.GLAMOURCAR;
        }

        public override bool IsEnabled()
        {
            return true;
        }

        public override int Tunning()
        {
            return Utils.GetRandomReal(1, 3);
        }

        public void MoveGlamour()
        {
            _position += 20;
        }
    }

    public class TroglodyteCar : Car
    {
        private int _position;

        public TroglodyteCar(string name, int position, int tunning):base(name, position, tunning)
        {

        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.TROGLODYTECAR;
        }

        public override bool IsEnabled()
        {
            return true;
        }

        public void MoveTroglodyte()
        {
            int result = 10;
            int bonus = Utils.GetRandomReal(0, 100);
            if (bonus > 30)
            {
                int extrabonus = Utils.GetRandomReal(0, 100);
                if (extrabonus < 20)
                {
                    result += 10;
                }
                else if (extrabonus > 20 && extrabonus < 60)
                {
                    result += 20;
                }
                else
                {
                    result += 0;
                }
            }
            _position += result;
        }
    }

    public class WoodCar : Car
    {
        private int _position;

        public WoodCar(string name, int position, int tunning):base(name, position, tunning)
        {

        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.WOODCAR;
        }

        public override bool IsEnabled()
        {
            return true;
        }

        public void MoveWood()
        {
            int result = 15;
            _position += result;
        }
    }

    public class PiereCar : Car
    {
        private int _position;

        public PiereCar(string name, int position, int tunning):base(name, position, tunning)
        {

        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.PIERECAR;
        }
        public override bool IsEnabled()
        {
            return true;
        }

        public void MovePiere()
        {
            int result = 18;
            _position += result;
        }


        /*
        public void ExtraPiere(Car backposition)
        {
            GetObjectAt()
        }
        */
    }

    public abstract class Driver
    {
        public abstract int GetVelocityExtra();
    }

    public class Animal : Driver
    {
        public override int GetVelocityExtra()
        {
            return 3;
        }
    }

    public class Human : Driver
    {
        public override int GetVelocityExtra()
        {
            return 0;
        }
    }
}
