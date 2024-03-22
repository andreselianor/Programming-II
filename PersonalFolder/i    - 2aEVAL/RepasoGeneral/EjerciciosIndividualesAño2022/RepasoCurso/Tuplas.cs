namespace RepasoCurso
{
    public class Tuplas
    {
        private string _name;
        private int _id;

        public (string,int) Set(string name,int id)
        {
            _name = name;
            _id = id;
            return (_name, _id);
        }

        public (string, int) Set2()
        {
            (string cadena, int numero) result2 = ("Prueba", 5);

            return (result2.cadena, result2.numero);
        }
    }
}
