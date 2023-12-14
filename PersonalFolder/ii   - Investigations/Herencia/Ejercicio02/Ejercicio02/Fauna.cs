namespace Ejercicio02
{
    public enum AnimalType
    {
        HERBIVORO,
        CARNIVORO,
        OMNIVORO,
        DESCOMPOSITOR,
        CANIS
    }
    public class Fauna : Ecosystem
    {
        private string _name;
        private AnimalType _animalType = AnimalType.HERBIVORO;
        private int _colectiveNumber;


        public Fauna()
        {
            _name = "Noni";
        }

        public Fauna(string name, AnimalType animalType, string ecoName) : base(ecoName)
        {
            _name = name;
            _animalType = AnimalType.CANIS;
            _colectiveNumber = 4;
        }

        public override void Duel()
        {
            int value = Utils.GetRandom();
            string result = "";

            switch (value)
            {
                case 0:
                    result = ("Tengo dispositivo conectado y operativo");
                    break;
                case 1:
                    result = ("Mi silencio es letal");
                    break;
                case 2:
                    result = ("Me dirige la necesidad de educar");
                    break;
            }

            if (_colectiveNumber >= 4)
            {
                result = "Por siempre Punk";
                string resultReverse = "";
                foreach (char c in result.Reverse())
                {
                    resultReverse += c;
                }
                Console.WriteLine(resultReverse);
            }
            else
            {
                Console.WriteLine(result);
            }            
        }
    }
}
