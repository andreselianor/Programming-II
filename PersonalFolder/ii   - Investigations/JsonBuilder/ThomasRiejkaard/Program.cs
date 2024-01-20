namespace ThomasRiejkaard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TagBuilder builder = new TagBuilder();

            int number = 50;
            for(int i = 0; i < number; i++)
            {
                builder.CallDelegate();
                builder.Serialize();
            }
            
            Console.ReadLine();
        }
    }
}