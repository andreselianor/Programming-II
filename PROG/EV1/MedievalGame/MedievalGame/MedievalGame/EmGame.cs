namespace MedievalGame
{
    public class EmGame
    {
        private Warzone warzone;
        private Team _winnerTeam;
        

        public void Play()
        {
            CreateBoard();

            /*
            bool areTeamsFighting = true;
            while (areTeamsFighting)
            {
                ExecuteTurn();
                areTeamsFighting = FinishTurn();
            }            

            Team? winnerTeam = FinishGame();
            Console.WriteLine($"El equipo ganador es: {winnerTeam}");
            */
        }


        public void CreateBoard()
        {
            int SquadCount = 2;
            warzone = new Warzone(SquadCount);
        }

        public bool FinishTurn()
        {
            int warriorsList1 = 0, warriorsList2 = 0;
            for (int i = 0; i < warzone.ListPlayers.Count; i++)
            {
                if (warzone.ListPlayers[i].Team == Team.LIGHT)
                    warriorsList1++;
                if (warzone.ListPlayers[i].Team == Team.DARK)
                    warriorsList2++;
            }

            return (warriorsList1 == 0 || warriorsList2 == 0);
        }

        public Team? FinishGame()
        {
            int warriorsList1 = 0, warriorsList2 = 0;
            for(int i = 0; i < warzone.ListPlayers.Count; i++)
            {
                if (warzone.ListPlayers[i].Team == Team.LIGHT)
                    warriorsList1++;
                if (warzone.ListPlayers[i].Team == Team.DARK)
                    warriorsList2++;
            }

            if (warriorsList1 == 0)
                return Team.DARK;
            if (warriorsList2 == 0)
                return Team.LIGHT;
            else
                return null;
        }

        public void ExecuteTurn()
        {

        }
    }
}
