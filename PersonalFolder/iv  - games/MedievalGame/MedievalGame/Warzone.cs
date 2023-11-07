namespace MedievalGame
{
    public class Warzone
    {
        private int _width;
        private int _height;
        private List<Warrior> _warriorList = new List<Warrior>();
        private int _isPlayerDefeated;

        public Warzone(int x, int y)
        {
            _width = x;
            _height = y;
        }

        public void Team1Fight()
        {
            for(int i = 0; i < _warriorList.Count;i++)
            {
                Warrior enemyWarrior = _warriorList[5];
                _warriorList[i].Attack(enemyWarrior);
            }
        }

        public void Team2Fight()
        {
            for (int i = 0; i < _warriorList.Count; i++)
            {
                Warrior enemyWarrior = _warriorList[5];
                _warriorList[i].Attack(enemyWarrior);
            }
        }

        public void TeamHealer()
        {

        }

        public void TeamMorale()
        {

        }
        public void FinalPhase()
        {
            int numberWarrior1 = 0, numberWarrior2 = 0;
            
            for(int i = 0; i < _warriorList.Count; i++)
            {
                if (_warriorList[i]._playerTeam == PlayerTeam.TEAM1)
                    numberWarrior1++;
                if (_warriorList[i]._playerTeam == PlayerTeam.TEAM2)
                    numberWarrior2++;
            }

            if (numberWarrior1 == 0)
                _isPlayerDefeated = 1;

            if (numberWarrior2 == 0)
                _isPlayerDefeated = 2;
        }


        public int PlayerDefeated()
        {
            return (_isPlayerDefeated);
        }
        
        public int GetListCount()
        {
            return _warriorList.Count;
        }

        public Warrior GetWarriorAt(int index, List<Warrior> list)
        {
            return list[index];
        }
    }
}
