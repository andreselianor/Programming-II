namespace MedievalGame
{
    public enum TeamType
    {
        HUMAN,
        DWARF,
        ORC,
        ELF
    }
    public enum PlayerTeam
    {
        TEAM1,
        TEAM2
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
        public PlayerTeam _playerTeam;

        public void Attack(Warrior enemy)
        {
            int attack = _weapon.GetDamage() * (int)_accuracity;
            enemy._life -= attack + _armor;
        }


    }
}
