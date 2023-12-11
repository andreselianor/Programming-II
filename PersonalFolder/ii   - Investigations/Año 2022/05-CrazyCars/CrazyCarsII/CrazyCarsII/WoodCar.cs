namespace CrazyCarsII
{
    public class WoodCar : Car
    {
        public override void Execute()
        {
            Position += 50;
        }
        public override void Report()
        {
            int report = Utils.SelectReport();
            switch (report)
            {
                case 0:
                    Console.WriteLine("Herr Weisse de WoodCar:\nMe desplazo en mi corvete a 50 millas/Hora");
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("Una bella dama me sonrie a través de su flamante Mercedes S750.\n" +
                        "El semaforo está en rojo. Pero tengo paciencia y espero.");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("Justo cuando me acerco al despacho encuentro sitio para aparcar\n" +
                        "Sin pensarlo demasiado aparco tranquilamente el coche y me dirigo a mi puesto de trabajo, bien remunerado");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Tengo una nota encima de mi mesa. Me la guardo discretamente en el bolsillo porque se que pertenece a Monique\n" +
                        "Esta noche la esperaré despierto");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
