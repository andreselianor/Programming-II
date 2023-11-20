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
        // SECCION 1: Atributos.

        private double _size;
        private double _life;
        private double _lifeCapacity;

        private string _name = "";
        private ColorType _Color;        


        // SECCION 2: Constructores.
        public Dolphin()
        {

        }

        public Dolphin(double currentLife, double maxLifeCapacity)
        {
            _life = currentLife;
            _lifeCapacity = maxLifeCapacity;
        }

        public Dolphin(double currentLife, double maxLifeCapacity, double size)
        {
            _life = currentLife;
            _lifeCapacity = maxLifeCapacity;
            _size = size;
        }


        // SECCION 3: Getters & Setters.
        public double GetLife()
        {
            return _life;
        }

        public void SetLife(int value)
        {
            _life = value;
        }

        /* 
            SETTERS CON VALIDACION DE PARAMETROS.
        
            CASO 1: CLAMPEAR/SATURAR, llevamos los valores a sus límites posibles.
            CASO 2: Comprobamos que los valores son CORRECTOS => establecemos el VALUE.
            CASO 3: Comprobamos que los valores son INCORRECTOS => Lanzamos un error.
        */
        public void SetLifeCase1(int value)
        {
            if (value < 0.0)
                _life = 0;
            else if (value > _lifeCapacity)
                _life = _lifeCapacity;
            else
                _life = value;
        }

        public void SetLifeCase2(int value)
        {
            if (0.0 <= value && value <= _lifeCapacity)
                _life = value;
            // else
            // el programa no hace nada                
        }

        public void SetLifeCase3(int value)
        {
            if (value < 0.0 || value > _lifeCapacity)
                throw new Exception("Error de validacion de parametros");
            _life = value;
        }


        // SECCION 4: Metodos.

        // FUNCION que devuelve el porcentaje de vida.
        // Tantos por 1.
        public double GetLifePercentOne()
        {
            return (_life / _lifeCapacity);
        }
        
        // Tantos por 100.
        public double GetLifePercent()
        {
            return (_life / _lifeCapacity) * 100;
        }
    }
}