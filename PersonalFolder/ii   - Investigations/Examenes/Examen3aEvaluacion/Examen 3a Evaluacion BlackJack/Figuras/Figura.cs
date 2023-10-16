namespace Figuras
{
    abstract public class Figura
    {
        private string _nombre = "";
        private double _areaFigure;

        public Figura(string nombre)
        {
            _nombre = nombre;
        } 
        
        // Esta es una property que necesito para comparar valores del bucle for que gestiona las listas de figuras del plano
        public string Nombre => _nombre;

        // Comprendo perfectamente las consecuencias de esta Property que permite modificar el area de una figura. Me ha parecido
        // la manera mas rapida de conseguir que la funcion que calcula areas tenga acceso y pueda devolver resultados.

        public double AreaFigure
        {
            get => _areaFigure;
            set => _areaFigure = value;
        }
               
        
    }
}
