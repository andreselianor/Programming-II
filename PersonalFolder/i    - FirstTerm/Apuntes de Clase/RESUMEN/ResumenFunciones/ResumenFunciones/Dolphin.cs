namespace ResumenFunciones
{
    public enum ColorType
    {
        BLUE,
        WHITE,
        BLACK
    }

    public class Dolphin
    {
        /*      ATRIBUTOS        */

        public double size;
        public double life;
        public double lifeCapacity;

        public string name = "";
        public ColorType Color;


        /*      CONSTRUCTOR      */

        public Dolphin(double currentLife, double maxLifeCapacity)
        {
            life = currentLife;
            lifeCapacity = maxLifeCapacity;
        }


        /*      FUNCIONES        */
        // Funcion que devuelve la vida restante
        // en tantos por cien

        public double GetLifePercent()
        {
            return (life / lifeCapacity) * 100;
        }


        // Funcion que devuelve la vida restante
        // en tantos por uno

        public double GetLifePercentOne()
        {
            return (life / lifeCapacity);
        }

        // GETTERS AND SETTERS

        public double GetLife()
        {
            return life;
        }

        public void SetLife(int value)
        {
            this.life = value;
        }


        // SETTERS CON VALIDACION DE PARAMETROS
        /*
            CASO 1: CLAMPEAR/SATURAR, llevamos los valores a sus límites posibles
            CASO 2: Comprobamos que los valores son CORRECTOS => establecemos el VALUE
            CASO 3: Comprobamos que los valores son INCORRECTOS => Lanzamos un error
        */

        public void SetLifeCase1(int value)
        {
            if (value < 0.0)
                this.life = 0;
            else if (value > lifeCapacity)
                this.life = lifeCapacity;
            else
                this.life = value;
        }

        public void SetLifeCase2(int value)
        {
            if (0.0 <= value && value <= lifeCapacity)
                this.life = value;
            // else
            // el programa no hace nada                
        }

        public void SetLifeCase3(int value)
        {
            if (value < 0.0 || value > lifeCapacity)
                throw new Exception("Error de validacion de parametros");
            this.life = value;
        }
    }
}