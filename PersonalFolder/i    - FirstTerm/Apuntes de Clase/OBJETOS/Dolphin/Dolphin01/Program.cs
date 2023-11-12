namespace Dolphin01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Echo the Dolphin");

            Character c1;
            Character c2;
            c1 = new Character();
            c2 = c1;

            c1.name = "VanDamme";
            c1.Type = CharacterType.POLICE;

            List<Character> list;
            list = new List<Character>();

            list.Add(c1);
            list.Add(c2);






        }
    }
}