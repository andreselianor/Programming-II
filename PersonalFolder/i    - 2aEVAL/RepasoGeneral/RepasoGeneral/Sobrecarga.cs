namespace RepasoGeneral
{
    public enum GenderPicker
    {
        AFROMALE,
        SEXYGIRL,
        CRAZYBILIVER,
        MISTERIOUSNUN,
        LITTLECRAZY
    }
    public class Sobrecarga
    {
        public int _value;
        public static int operator + (Sobrecarga number1, Sobrecarga number2)
        {
            return number1._value - number2._value;
        }

        public static string operator - (Sobrecarga s1, Sobrecarga s2)
        {
            return "Los operadores de Sobrecarga estan restando";
        }

        public static double operator * (Sobrecarga s1, Sobrecarga s2)
        {
            return s1._value * s2._value * 0.01;
        }

        public static GenderPicker operator / (Sobrecarga s1, Sobrecarga s2)
        {
            Random random = new Random();
            int selection = random.Next(5);

            return (GenderPicker)selection;
        }
    }
}