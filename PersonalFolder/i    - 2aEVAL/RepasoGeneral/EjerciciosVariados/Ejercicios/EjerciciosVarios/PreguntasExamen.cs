namespace EjerciciosVarios
{
    // EJERCICIO 1
    //public class ClaseA1
    //{
    //    protected int attribute;

    //    public abstract int GetAttribute();
    //}
    //public class ClaseB1 : ClaseA1
    //{
    //    public override int GetAttribute()
    //    {
    //        return attribute;
    //    }
    //}
    // Se debe declarar la clase como 'abstract' en caso que tengamos un metodo 'abstract'.


    // EJERCICIO 2
    public class ClaseA2
    {
        protected string name;

        public ClaseA2()
        {

        }
        public ClaseA2(string name)
        {
            this.name = name;
        }
    }
    public class ClaseB2 : ClaseA2 
    {
        //public ClaseA2()
        //{
        //    this.name = name;
        //}
        //public ClaseA2(string name)
        //{
        //    this.name = name;
        //}
    }
    // No se puede invocar al constructor de otra clase.

    // EJERCICIO 3
    public enum TipoCarta { OROS, COPAS, BASTOS, ESPADAS }
    public class CartaBarajaEspañola
    {
        private TipoCarta _tipo;
        private int _numero;
        private List<CartaBarajaEspañola> cartas = new List<CartaBarajaEspañola>();
    }
    // La clase Carta no contiene una lista de cartas.

    //EJERCICIO 4
    public class A3
    {
        public virtual void f1()
        {
            Console.WriteLine("A");
        }        
    }

    public class B3 : A3
    {
        public override void f1()
        {
            Console.WriteLine("B");
            A3 a = this;
            a.f1();
        }
    }
    // Entra en un bucle infinito.

    // EJERCICIO 5
    public class A4
    {
        public virtual void f1()
        {
            Console.WriteLine("A");
        }
    }

    public class B4 : A4
    {
        public override void f1()
        {
            Console.WriteLine("B");
        }
    }

    public class C4 : B4
    {
        public override void f1()
        {
            Console.WriteLine("C");
            base.f1();
        }
    }

}
