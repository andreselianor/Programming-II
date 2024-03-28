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
            WeaponType type = this._weaponType;
            switch (type)
            {
                case WeaponType.PUNCH:
                    return 1;
                    break;
                case WeaponType.SWORD:
                    return 5;
                    break;
                case WeaponType.BOW:
                    return 15;
                    break;
                case WeaponType.MAZE:
                    return 30;
                    break;
                case WeaponType.ARROW:
                    return 35;
                    break;
            }
            return 0;
        }

        public int GetReloadTime()
        {
            return 10;
        }
    }
}
