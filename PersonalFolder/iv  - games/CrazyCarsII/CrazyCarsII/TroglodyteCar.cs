﻿namespace CrazyCarsII
{
    public class TroglodyteCar : Car
    {
        public override void Execute()
        {
            Position += 30;
        }

        public override void Report()
        {
            Console.WriteLine("Pareja de Cromagnones de TroglodyteCar:");
            int report = Utils.SelectReport();
            switch (report)
            {
                case 0:
                    Console.WriteLine("Me muevo habitualmente caminando o en bus");
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("Circulo de forma brusca y a veces en lugar de mirar la calzada me fijo en las mujeres guapas que conducen.");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("Llevo la música a todo volumen. Me cuesta escuchar los sonidos de la calle.");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Se suben los colegas. Me ofrecen una cerveza fria 5.0. No me resisto a darle un par de buenos tragos.");
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("Llevo a Pierre delante. El cuerpo me pide utilizar el pito y darle un buen susto.");
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("Llevo un disco de Iron Maiden en la guantera. Por si acaso me toca llevar a alguno de la banda en el coche.");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
