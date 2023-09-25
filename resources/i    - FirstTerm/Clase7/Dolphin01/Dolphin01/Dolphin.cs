namespace Dolphin01
{
    public enum ColorType
    {
        BLUE,
        WHITE,
        BLACK
    }

    public class Dolphin
    {
        // Atributos


        /* Errores clasicos
        public static double size;
        public static double life(int number);
        public string name = "";
        public ColorType Color;
        */

        public double size;
        public double life;
        public double xPosition;
        public string name = "";
        public ColorType Color;



        public void Move(double number)
        {
            xPosition += number;
        }
    }
}
