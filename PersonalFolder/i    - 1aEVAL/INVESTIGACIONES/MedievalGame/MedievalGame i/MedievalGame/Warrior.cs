namespace MedievalGame
{
    public enum TeamType
    {
        HUMAN,
        DWARF,
        ORC,
        ELF
    }

    public class Warrior
    {
        private int _x;
        private int _y;

        private int _life;
        private double _accuracity;        
        private int _armor;
        private double _lucky;

        private TeamType _type;
        private Weapon _weapon;

        private int _tryAttack;

        public int X => _x;
        public int Y => _y;

        public void SetPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }
                
        public void ExecuteWarrior(Warzone warzone)
        {
            int index = 5;
            if (_tryAttack > 50)
            {
                Attack(warzone.GetWarriorAt(index));
            }
            else
            {
                Move(1,1);
            }
        }

        public void Attack(Warrior enemy)
        {
            int attack = _weapon.GetDamage() * (int)_accuracity;
            enemy._life -= attack + _armor;
        }

        public void Move(int x, int y)
        {
            SetPosition(x, y);
        }
    }
}
