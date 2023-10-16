namespace DragonBall
{
    public class Torneo : ITorneo
    {
        public List<Persona> listFighters = new List<Persona>();

        // Ejecuta el combate
        public List<string> Execute()
        {
            List<string> ganador = new List<string>();
            Init();
            Visit();

            bool FightingPlayers = true;
            while (FightingPlayers)
            {
                listFighters[0].Attack(listFighters[1]);
                listFighters[1].Attack(listFighters[0]);

                if (listFighters[0].Energy < 0)
                {
                    ganador.Add(listFighters[1].Name);
                    FightingPlayers = false;
                }                    

                if (listFighters[1].Energy < 0)
                {
                    ganador.Add(listFighters[0].Name);
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
            Humano jugador1 = new Humano("Flaqui");
            listFighters.Add(jugador1);

            Saiyan jugador2 = new Saiyan("PetroTordo");
            listFighters.Add(jugador2);
        }

        public void Visit()
        {
            foreach(Persona jugador in listFighters)
            {
                Console.WriteLine("Luchador: " + jugador.Name);
            }
        }
    }
}
