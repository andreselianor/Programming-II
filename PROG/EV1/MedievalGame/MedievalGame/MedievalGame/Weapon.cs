namespace MedievalGame
{
    public enum WeaponType
    {
        PUNCH,
        SWORD,
        BOW,
        MAZE
    }
    public class Weapon
    {
        private int _weaponPower;
        private WeaponType _weaponType;

        public Weapon(WeaponType weapon)
        {
            _weaponType = weapon;
        }

        public WeaponType Type => _weaponType;

        public static int GetDamage(WeaponType weaponType)
        {
            switch (weaponType)
            {
                case WeaponType.PUNCH:
                    return 1;
                case WeaponType.SWORD:
                    return 10;
                case WeaponType.BOW:
                    return 15;
                case WeaponType.MAZE:
                    return 30;
            }
            return 0;
        }
    }
}
