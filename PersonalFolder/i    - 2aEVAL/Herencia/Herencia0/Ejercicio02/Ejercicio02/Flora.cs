namespace Ejercicio02
{
    public enum FloraType
    {
        COLORED,
        DIGERIBLE,
        GRASS
    }
    public class Flora : Ecosystem
    {
        private string _name;
        private FloraType _floraType;
        private double _waterNeeds;

        public Flora()
        {
            _name = "Petty";
            _floraType = FloraType.COLORED;
        }

        public Flora(double adaptability) : base(adaptability)
        {
            _name = "Mamba";
            _floraType = FloraType.GRASS;
        }

        public override void Duel()
        {
            int value = Utils.GetRandom();
            string result = "";

            switch (value)
            {
                case 0:
                    result = ("Soy bella y mi cuerpo es sincero");
                    break;
                case 1:
                    result = ("Mi paciencia es natural");
                    break;
                case 2:
                    result = ("El silencio me mece en reposo");
                    break;
            }

            if (Adaptability > 5.0)
                result = result.ToUpper();
            Console.WriteLine(result);
        }
    }
}
