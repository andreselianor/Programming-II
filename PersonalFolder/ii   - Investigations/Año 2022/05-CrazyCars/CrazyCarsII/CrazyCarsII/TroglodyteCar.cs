namespace CrazyCarsII
{
    public class TroglodyteCar : Car
    {
        public override void Execute()
        {
            Position += 30;
        }

        public override void Report()
        {
            int report = Utils.SelectReport();
            switch (report)
            {
                case 0:
                    Console.WriteLine("Pareja de Cromagnones de TroglodyteCar:\nMe muevo habitualmente caminando o en bus");
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("El cielo está gris y seguro que llueve. Mi coche no es descapotable\n" +
                        "y aun así hace agua por todas partes.");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("Atasco en la via principal de acceso a la ciudad\n" +
                        "Puedo tomar un atajo que me llevará directo a mi destino\n" +
                        "50 personas han pensado lo mismo que yo y ahora me toca volver a esperar");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Que buena fortuna\n" +
                        "Un grupo de monjas ha subido a mi vehículo y no llevan maquillaje ni móviles en la mano\n" +
                        "Mientras me llevan a mi destino, hablamos sobre los asuntos de virgenes y pastores\n" +
                        "el tiempo pasa volando y casi no me entero de los gritos de los coches de mi alrededor");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
