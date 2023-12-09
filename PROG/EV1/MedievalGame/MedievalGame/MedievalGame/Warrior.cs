using UDK;

namespace MedievalGame
{
    public enum WarriorType
    {
        HUMAN,
        DWARF,
        ELF,
        ORC
    }

    public class Warrior
    {
        Position position = new Position();

        private int _life;
        private Weapon _weapon;

        private WarriorType _type;
        private Team _team;



        #region Constructor
        public Warrior()
        {

        }

        public Warrior(int x, int y, int life, WarriorType type, Weapon weapon, Team team)
        {
            position.SetPosition(x, y);
            _life = life;
            _type = type;
            _weapon = weapon;
            _team = team;
        }
        #endregion



        public Team Team => _team;
        public Position Position => position;

        public void Move(int x, int y)
        {
            position.SetPosition(x, y);
        }

        public void Attack(Warrior warrior)
        {
            int weaponDamage = Weapon.GetDamage(_weapon.Type);
            warrior._life -= weaponDamage;

            if (warrior._life <= 0)
                warrior = null;
        }



        #region PaintMethods
        public void PaintWarrior(ICanvas canvas)
        {
            // Javi: copy paste peligroso, hacer funciones
            if(_type == WarriorType.HUMAN)
            {
                double r = 1.0, g = 1.0, b = 0.5, a = 1.0;
                double scale = 0.9;

                canvas.FillShader.SetColor(r, g, b, a);
                canvas.DrawRectangle(position.X, position.Y, scale, scale);
            }

            if (_type == WarriorType.DWARF)
            {
                double r = 1.0, g = 0.3, b = 0.3, a = 1.0;
                double scale = 0.9;

                canvas.FillShader.SetColor(r, g, b, a);
                canvas.DrawRectangle(position.X, position.Y, scale, scale);
            }

            if (_type == WarriorType.ELF)
            {
                double r = 0.3, g = 1.0, b = 0.4, a = 1.0;
                double scale = 0.9;

                canvas.FillShader.SetColor(r, g, b, a);
                canvas.DrawRectangle(position.X, position.Y, scale, scale);
            }

            if (_type == WarriorType.ORC)
            {
                double r = 0.5, g = 0.3, b = 0.2, a = 1.0;
                double scale = 0.9;

                canvas.FillShader.SetColor(r, g, b, a);
                canvas.DrawRectangle(position.X, position.Y, scale, scale);
            }
        }
        #endregion
    }
}
