namespace DragonBall
{
    public class Torneo : ITorneo
    {
        public List<Persona> listFighters = new List<Persona>();

        // Ejecuta el combate
        public List<Persona> Execute()
        {
            List<Persona> ganador = new List<Persona>();
            Init();
            Visit();

            bool FightingPlayers = true;
            while (FightingPlayers)
            {
                listFighters[0].Attack(listFighters[1]);
                listFighters[1].Attack(listFighters[0]);

                if (listFighters[0].Energy < 0)
                {
                    ganador.Add(listFighters[1]);
                    FightingPlayers = false;
                }                    

                if (listFighters[1].Energy < 0)
                {
                    ganador.Add(listFighters[0]);
                    FightingPlayers = false;
                }
                Console.WriteLine(listFighters[0].Energy);
                Console.WriteLine(listFighters[1].Energy);
                Console.ReadLine();            
            }

            return ganador;
        }

        public void Init()
        {
            Persona jugador1 = new Saiyan("RojoPatoso");
            listFighters.Add(jugador1);

            Persona jugador2 = new Namekiano("PetroTordo");
            listFighters.Add(jugador2);
        }

        public void Visit()
        {
            foreach(Persona jugador in listFighters)
            {
                Console.WriteLine("Luchador: " + jugador.Name);
            }
        }

        public Persona Winner()
        {
            return listFighters[0];
        }
    }
}
