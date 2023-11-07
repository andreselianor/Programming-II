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

        public void ExecuteTurn(Warzone warzone)
        {
            if (_tryAttack > 50)
            {
                Attack();
            }
            else
            {
                Move();
            }
        }

        public void Attack(Warrior enemy)
        {
            int attack = _weapon.GetDamage() * (int)_accuracity;
            enemy._life -= attack + _armor;
        }

        public void Move(Warrior enemy)
        {

        }


    }
}
