namespace HerenciaI
{
    public class Teacher : Person
    {
        public double _bloodlust;

        public Teacher()
        {

        }

        public Teacher(double bloodlust)
        {
            _bloodlust = bloodlust;
        }

        // Si quiero pasarle un nombre, tengo que llamar al constructor BASE de parámetros

        public Teacher(string name, Gender gender, double bloodlust) : base(name, gender)
        {
            _bloodlust = bloodlust;
        }
    }
}
