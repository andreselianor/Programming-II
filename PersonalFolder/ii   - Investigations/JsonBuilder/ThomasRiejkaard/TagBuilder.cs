using System.Text;
using System.Text.Json;

namespace ThomasRiejkaard
{
    public class TagBuilder
    {
        private string _tag = "";
        private StringBuilder _builder = new StringBuilder();
        private Random _random = new Random();
        public delegate void DelegateAdd();


        public void AddCharacter()
        {
            char letter = (char)_random.Next(97, 123);
            _builder.AppendFormat("" + letter);
        }
        public void AddMajorCharacter()
        {
            char letter = (char)_random.Next(65, 91);
            _builder.AppendFormat("" + letter);
        }
        public void AddSimbol()
        {
            char letter = (char)_random.Next(34, 48);
            _builder.AppendFormat("" + letter);
        }
        public void AddNumber()
        {
            char letter = (char)_random.Next(48, 58);
            _builder.AppendFormat("" + letter);
        }
        public void AddAlter()
        {
            char letter = (char)_random.Next(166, 180);
            _builder.AppendFormat("" + letter);
        }

        public void WriteDownTag()
        {
            int number = 2;
            for (int i = 0; i < number; i++)
            {
                AddMajorCharacter();
            }
            for (int i = 0; i < 2; i++)
            {
                AddNumber();
            }
            for (int i = 0; i < 4; i++)
            {
                AddSimbol();
            }
            for (int i = 0; i < number; i++)
            {
                AddCharacter();
            }
        }


        public void CallDelegate()
        {
            DelegateAdd delegado = new DelegateAdd(WriteDownTag);
            delegado();
        }

        public void Print()
        {
            Console.WriteLine(_builder);
        }

        public void Serialize()
        {
            string fileName = "../../../JsonText.Json";
            string jsonString = JsonSerializer.Serialize(_builder.ToString());
            //File.WriteAllText(fileName, jsonString);
            File.AppendAllText(fileName, jsonString);
        }
    }
}
