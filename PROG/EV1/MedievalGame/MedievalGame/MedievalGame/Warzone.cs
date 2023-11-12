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

        #region Constructores
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
        #endregion

        #region Properties
        public List<Warrior> ListWarrior => _listWarrior;
        #endregion

        public void CreateTeamLight(int squadCount)
        {
            int humanLife = 10, dwarfLife = 15, elfLife = 25, orcLife = 8;
            for (int i = 0; i < squadCount; i++)
            {
                Warrior warrior;
                Weapon weapon = new Weapon(WeaponType.SWORD);

                warrior = new Warrior(i, 8, humanLife, WarriorType.HUMAN, weapon, Team.LIGHT);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i + 3, 8, dwarfLife, WarriorType.DWARF, weapon, Team.LIGHT);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i + 4, 8, elfLife, WarriorType.ELF, weapon, Team.LIGHT);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i + 7, 8, orcLife, WarriorType.ORC, weapon, Team.LIGHT);
                _listWarrior.Add(warrior);
            }
        }

        public void CreateTeamDark(int squadNumber)
        {
            int humanLife = 10, dwarfLife = 15, elfLife = 25, orcLife = 8;
            for (int i = 0; i < squadNumber; i++)
            {
                Warrior warrior;
                Weapon weapon = new Weapon(WeaponType.SWORD);

                warrior = new Warrior(i, 3, humanLife, WarriorType.HUMAN, weapon, Team.DARK);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i + 2, 3, dwarfLife, WarriorType.DWARF, weapon, Team.DARK);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i + 3, 3, elfLife, WarriorType.ELF, weapon, Team.DARK);
                _listWarrior.Add(warrior);

                warrior = new Warrior(i + 5, 3, orcLife, WarriorType.ORC, weapon, Team.DARK);
                _listWarrior.Add(warrior);
            }
        }

        public void Move()
        {

        }

        public void Attack()
        {

        }

        #region PaintMethods
        public void PaintWarzone(ICanvas canvas)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    double r = 0.0, g = 0.4, b = 0.4, a = 0.5;

                    canvas.FillShader.SetColor(r, g, b, a);
                    canvas.DrawRectangle(i, j, 0.9, 0.9);
                }
            }
        }

        public void PaintWarriors(ICanvas canvas)
        {
            for (int i = 0; i < ListWarrior.Count; i++)
            {
                ListWarrior[i].PaintWarrior(canvas);
            }
        }
        #endregion
    }
}
