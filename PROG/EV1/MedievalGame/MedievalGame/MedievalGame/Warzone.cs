using UDK;

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
                Weapon weapon = new Weapon(WeaponType.SWORD);

                warrior = new Warrior(i,1, humanLife, WarriorType.HUMAN, weapon, Team.LIGHT);
                _listWarrior.Add(warrior);

                /*
                warrior = new Warrior(i, 1, dwarfLife, WarriorType.DWARF, WeaponType.MAZE, Team.LIGHT);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, elfLife, WarriorType.ELF, WeaponType.BOW, Team.LIGHT);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, orcLife, WarriorType.ORC, WeaponType.PUNCH, Team.LIGHT);
                _listWarrior.Add(warrior);
                */
            }
        }

        public void CreateTeamDark(int squadNumber)
        {
            int humanLife = 10, dwarfLife = 15, elfLife = 25, orcLife = 8;
            for (int i = 0; i < squadNumber; i++)
            {
                Warrior warrior;
                Weapon weapon = new Weapon(WeaponType.SWORD);

                warrior = new Warrior(i, 9, humanLife, WarriorType.HUMAN, weapon, Team.DARK);
                _listWarrior.Add(warrior);

                /*
                warrior = new Warrior(i, 1, dwarfLife, WarriorType.DWARF, WeaponType.MAZE, Team.DARK);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, elfLife, WarriorType.ELF, WeaponType.BOW, Team.DARK);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i, 1, orcLife, WarriorType.ORC, WeaponType.PUNCH, Team.DARK);
                _listWarrior.Add(warrior);
                */
            }
        }

        public void PaintWarzone(ICanvas canvas)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    canvas.FillShader.SetColor(0, 0, 0, 1);
                    canvas.DrawRectangle(i, j, 0.9, 0.9);
                }
            }
        }

        public void PaintWarriors(ICanvas canvas)
        {
            for(int i = 0; i < ListPlayers.Count; i++)
            {
                ListPlayers[i].PaintWarrior(canvas);
            }
        }
    }
}
