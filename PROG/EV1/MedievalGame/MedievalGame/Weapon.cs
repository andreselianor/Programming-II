namespace MedievalGame
{
    public enum WeaponType
    {
        PUNCH,
        SWORD,
        BOW,
        MAZE,
        ARROW
    }
    public class Weapon
    {
        private WeaponType _weaponType;


        public WeaponType GetWeaponType()
        {
            return _weaponType;
        }

        public int GetDamage()
        {
            return 1;
        }

        public int GetReloadTime()
        {
            return 1;
        }
    }
}
