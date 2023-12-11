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
            int report = Utils.SelectReport();
            switch (report)
            {
                case 0:
                    Console.WriteLine("Pierre el maleducado de PierreCar:\nLa gente de hoy en día no sabe conducir. ¿Quien les entregó su permiso de conducir?");
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("Llego tarde al trabajo. Quiero pisar el acelerador pero los demás coches me lo impiden\n" +
                        "Todo el mundo conduce horriblemente en esta ciudad\nTengo prisa");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("Esto es increbile, fijate y explicame porqué se para justo delante del semaforo en ámbar\n" +
                        "Tengo prisa es que no se da cuenta que no pasan peatones?");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("¡¡Realmente no se entera!!¡¡¡PIIIIII!!!Sal de mi camino, pareces un conductor, conductora de ganado!!!¡¡Aprende a conducir!!!");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
