namespace ExercismIII
{
    public class Test
    {
        private string _text = "Por defecto";

        public string Texto(string text = "pordefecto2")
        {
            string result;

            result = text?? "ultimo";
            return result;
        }
    }
}
