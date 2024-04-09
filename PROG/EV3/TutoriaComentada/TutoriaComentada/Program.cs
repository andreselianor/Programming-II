using System.Runtime.Intrinsics.X86;

namespace TutoriaComentada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.RunTest();

            // Aqui van los comentarios sobre la ejecucion del programa
            // <see cref="index.html">Comentarios</see>

            //<see href = "https://github.com" > GitHub </see>
        }
    }
}
