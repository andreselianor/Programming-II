namespace MedievalGame
{
    public class EmGame
    {
        private Warzone warzone;


        public void Play()
        {
            // Javi: Esto yo no lo pondría aquí
            CreateBoard();

            // Javi: Esta variable te la puedes ahorrar
            bool areTeamsFighting = true;
            while (areTeamsFighting)
            {
                ExecuteTurn();
                areTeamsFighting = FinishTurn();
            }            

            Team? winnerTeam = WinnerTeam();
            Console.WriteLine($"El equipo ganador es: {winnerTeam}");            
        }


        public void CreateBoard()
        {
            int SquadCount = 1;
            warzone = new Warzone(SquadCount);
        }

        public void ExecuteTurn()
        {
            warzone.Move();
            warzone.Attack();
        }

        // Javi: Mal nombre de función
        public bool FinishTurn()
        {
            int warriorsList1 = 0, warriorsList2 = 0;
            for (int i = 0; i < warzone.ListWarrior.Count; i++)
            {
                if (warzone.ListWarrior[i].Team == Team.LIGHT)
                    warriorsList1++;
                if (warzone.ListWarrior[i].Team == Team.DARK)
                    warriorsList2++;
            }

            return (warriorsList1 == 0 || warriorsList2 == 0);
        }

        // Javi: GetWinnerTeam
        public Team? WinnerTeam()
        {
            // Javi: mal nombre de variables
            int warriorsCountTeam1 = 0, warriorsCountTeam2 = 0;
            for(int i = 0; i < warzone.ListWarrior.Count; i++)
            {
                if (warzone.ListWarrior[i].Team == Team.LIGHT)
                    warriorsCountTeam1++;
                if (warzone.ListWarrior[i].Team == Team.DARK) // Javi: else?
                    warriorsCountTeam2++;
            }

            if (warriorsCountTeam1 == 0)
                return Team.DARK;
            if (warriorsCountTeam2 == 0)
                return Team.LIGHT;
            else
                return null;
        }        
    }
}
