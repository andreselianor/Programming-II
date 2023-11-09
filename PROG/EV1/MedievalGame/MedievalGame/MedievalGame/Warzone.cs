namespace MedievalGame
{
    public enum Team
    {
        LIGHT,
        DARK           
    }

    public class Warzone
    {
        private List<Warrior> _listWarrior = new List<Warrior>();        


        public Warzone()
        {
            CreateTeamLight(1);
            CreateTeamDark(1);
        }

        public Warzone(int squadCount)
        {
            CreateTeamLight(squadCount);
            CreateTeamDark(squadCount);
        }

        public List<Warrior> ListPlayers => _listWarrior;


        public void CreateTeamLight(int squadCount)
        {
            int humanLife = 10, dwarfLife = 15, elfLife = 25, orcLife = 8;
            for(int i = 0; i < squadCount; i++)
            {
                Warrior warrior;

                warrior = new Warrior(i,1, humanLife, WarriorType.HUMAN, WeaponType.SWORD, Team.LIGHT);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, dwarfLife, WarriorType.DWARF, Team.LIGHT);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, elfLife, WarriorType.ELF, Team.LIGHT);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, orcLife, WarriorType.ORC, Team.LIGHT);
                _listWarrior.Add(warrior);
            }
        }

        public void CreateTeamDark(int squadNumber)
        {
            int humanLife = 10, dwarfLife = 15, elfLife = 25, orcLife = 8;
            for (int i = 0; i < squadNumber; i++)
            {
                Warrior warrior;

                warrior = new Warrior(i, 1, humanLife, WarriorType.HUMAN, Team.DARK);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, dwarfLife, WarriorType.DWARF, Team.DARK);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, elfLife, WarriorType.ELF, Team.DARK);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, orcLife, WarriorType.ORC, Team.DARK);
                _listWarrior.Add(warrior);
            }
        }
    }
}
