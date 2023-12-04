namespace Exercism
{
    public enum CharacterType
    {
        Warrior,
        Wizard
    }
    public abstract class Character
    {
        protected string _name = "";
        protected CharacterType _type;
        protected bool _isVulnerable = false;

        public Character()
        {

        }

        public Character(string name)
        {
            _name = name;
        }

        public Character(string name, CharacterType type)
        {
            _name = name;
            _type = type;
        }

        public abstract string ToString();
        public abstract bool Vulnerable();
        public abstract int DamagePoints(Character target);
    }

    public class Warrior : Character
    {

        public Warrior() : base()
        {

        }

        public Warrior(string name) : base(name)
        {

        }

        public Warrior(string name, CharacterType type) : base(name, type)
        {

        }

        public override string ToString()
        {
            return "Character is a Warrior";
        }

        public override bool Vulnerable()
        {
            return _isVulnerable;
        }

        public override int DamagePoints(Character target)
        {
            if (target.Vulnerable() == true)
                return 10;
            return 6;
        }
    }

    public class Wizard : Character
    {
        private bool _spellReady;
        public Wizard() : base()
        {
            _isVulnerable = true;
        }

        public Wizard(string name) : base(name)
        {
            _isVulnerable = true;
        }

        public Wizard(string name, CharacterType type) : base(name, type)
        {
            _isVulnerable = true;
        }

        public override string ToString()
        {
            return "Character is a Wizard";
        }

        public override bool Vulnerable()
        {
            return _isVulnerable;
        }

        public override int DamagePoints(Character target)
        {
            if (_spellReady)
                return 12;
            return 3;
        }

        public void PrepareSpell()
        {
            _spellReady = true;
            _isVulnerable = false;
        }
    }
}
