namespace CrazyCarsII
{
    public class PierreCar : Car
    {
        public override void Execute()
        {
            Position += 70;
        }

        public override void Report()
        {
            Console.WriteLine("Pierre el maleducado de PierreCar:");
            int report = Utils.SelectReport();
            switch (report)
            {
                case 0:
                    Console.WriteLine("La gente de hoy en día no sabe conducir. ¿Quien les dio su permiso de conducir?");
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("Me salto un semáforo en rojo. Tengo prisa.");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("Intento adelantar por la izquierda. Creo que es mujer y no sabe conducir.");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Tomo el atajo de la calle peatonal. No hace falta respetar los límites, todos los peatones van demasiado lentos.");
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("La chica que llevo delante está intentado aparcar. Intento ponerla nerviosa con mi presencia masculina.");
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("¡¡Realmente no se entera!!¡¡¡PIIIIII!!!Sal de mi camino, pareces un conductor, conductora de ganado!!!¡¡Aprende a conducir!!!");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
