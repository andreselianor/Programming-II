using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCrazyRace
{
    public class Race : IRace
    {
        public void Iniciar(int distance)
        {
            int RaceDistance = distance;

            List<RaceObject> listaObjetos = new List<RaceObject>();

            // Genero los participantes
            int GlamourTunning = Utils.GetRandomReal(1, 3);
            GlamourCar P1 = new GlamourCar("Persefone", 0, GlamourTunning);

            int TroglodyteTunning = Utils.GetRandomReal(1, 3);
            TroglodyteCar P2 = new TroglodyteCar("Picapiedra", 0, TroglodyteTunning);

            int WoodTunning = Utils.GetRandomReal(1, 3);
            WoodCar P3 = new WoodCar("WoodMan", 0, WoodTunning);

            int PiereTunning = Utils.GetRandomReal(1, 3);
            PiereCar P4 = new PiereCar("Piere", 0, PiereTunning);

            listaObjetos.Add(P1);
            listaObjetos.Add(P2);
            listaObjetos.Add(P3);
            listaObjetos.Add(P4);

            // Genero los obstaculos ROCA
            // NOTA: Se muy bien que tu no nos has enseñado a hacer este metodo de esta manera, pero empieza a ser tarde y no llego
            // al resto del examen.
            // El problema es que no se como Generar MAS de una instancia de cada obstaculo, he probado con un for,
            // y con un Switch. Ninguna solucion me convence.
            int numeroObstaculosRock = Utils.GetRandomReal(2, 4);
            int rockWeight = Utils.GetRandomReal(10, 30);
            int placingRock = Utils.GetRandomReal(0, RaceDistance);
            Rock R1 = new Rock("Roca1", placingRock, rockWeight);

            // POSIBILIDADES para crear mas de una instancia.
            for (int i = 2; i < numeroObstaculosRock; i++)
            {
                Rock R11 = new Rock("Roca", placingRock, rockWeight);
            }

            switch (numeroObstaculosRock)
            {
                case 2:
                    Rock R12 = new Rock("Roca", placingRock, rockWeight);
                    Rock R2 = new Rock("Roca", placingRock, rockWeight);
                    break;
                case 3:
                    Rock R3 = new Rock("Roca", placingRock, rockWeight);
                    Rock R4 = new Rock("Roca", placingRock, rockWeight);
                    Rock R5 = new Rock("Roca", placingRock, rockWeight);
                    break;
                case 4:
                    Rock R6 = new Rock("Roca", placingRock, rockWeight);
                    Rock R7 = new Rock("Roca", placingRock, rockWeight);
                    Rock R8 = new Rock("Roca", placingRock, rockWeight);
                    Rock R9 = new Rock("Roca", placingRock, rockWeight);
                    break;
                default:
                    Rock R10 = new Rock("Roca", placingRock, rockWeight);
                    break;
            }

            // Genero los obstaculos Charco

            int numeroObstaculosCharco = Utils.GetRandomReal(2, 4);            
            int placingCharco = Utils.GetRandomReal(0, RaceDistance);
            Charco C1 = new Charco("Charco1", placingCharco);

            // Genero los obstaculos Bomb

            int numeroObstaculosBomb = Utils.GetRandomReal(2, 4);
            int explodeTurn = Utils.GetRandomReal(0, 10);
            int placingBomb = Utils.GetRandomReal(0, RaceDistance);
            Bomb B1 = new Bomb("Bomba1", placingBomb, explodeTurn);

            listaObjetos.Add(R1);
            listaObjetos.Add(C1);
            listaObjetos.Add(B1);

        }

        public List<RaceObject> ListaInicio()
        {
            List<RaceObject> lista = new List<RaceObject>();
            
            return lista;
        }

        public List<RaceObject> ObjetosActivos()
        {

            // Aqui actualizaria la lista de los objetos que estan en modo activo.
            // Son estos los que mueven cada turno.
            List<RaceObject> listaActivos = new List<RaceObject>();
            return listaActivos;

        }

        public List<RaceObject> Simulate()
        {
            /*
            Iniciar(1000);
            List<RaceObject> listaparticipantes = ObjetosActivos();
            
            if(listaparticipantes.Position == 1000)

            while (winner == false)
            {
                listaObjetos;
            }*/
            List<RaceObject> listaObjetos = new List<RaceObject>();                      
            
            return listaObjetos;
        }
        public void PrintDrivers()
        {
            List<RaceObject> list = Simulate();
            foreach (RaceObject R in list)
            {
                Console.WriteLine(R);
            }
        }
        public int GetObjectCount()
        {
            List<RaceObject> list = Simulate();
            int count = 0;

            foreach (RaceObject R in list)
            {
                count += 1;
            }
            return count;
        }
        public RaceObject GetObjectAt(int index)
        {
            List<RaceObject> list = Simulate();
            return list[index];
        }
    }
}
