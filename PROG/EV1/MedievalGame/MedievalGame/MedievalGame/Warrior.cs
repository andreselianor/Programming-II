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



        public Warrior()
        {

        }

        public Warrior(int x, int y, int life, WarriorType type, WeaponType weapon, Team team)
        {
            position.SetPosition(x, y);
            _life = life;
            _type = type;
            _weapon = weapon;
            _team = team;
        }



        public Team Team => _team;

        public void Attack(Warrior warrior)
        {
            int weaponDamage = Weapon.GetDamage(_weapon.Type);
            warrior._life -= weaponDamage;

            if (warrior._life <= 0)
                warrior = null;
        }


        public void Move(int x, int y)
        {
            position.SetPosition(x, y);
        }
    }
}
