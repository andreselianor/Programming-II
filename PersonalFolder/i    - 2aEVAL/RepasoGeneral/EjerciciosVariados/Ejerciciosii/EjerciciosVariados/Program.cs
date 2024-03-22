namespace EjerciciosVariados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.f1();
        }
    }

    public class A
    {
        public virtual void f1()
        {
            Console.WriteLine("A");
        }
    }
    public class B : A
    {
        public override void f1()
        {
            Console.WriteLine("B");
            A a = new A();
            a.f1();
        }
    }
}
