namespace Dolphin01
{
    public enum CharacterType
    {
        POLICE,
        THIEF
    }
    public class Character
    {
        // Atributos
        public string name = "";
        public CharacterType Type = CharacterType.POLICE;
        public double x = 0.0;
        public double y = 0.0;
        public double size = 1.0;
        public double velocity = 1.0;

    }
}
