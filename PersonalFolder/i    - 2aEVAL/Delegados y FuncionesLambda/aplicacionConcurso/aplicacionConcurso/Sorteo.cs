namespace aplicacionConcurso
{
    public class Sorteo
    {
        private List<string> _listOptions;
        
        public void CreateList()
        {
            _listOptions = new List<string>
            {
                "Open TTD",
                "HomeWorld",
                "Guild III",
                "Victoria III"
            };
        }

        public void SwapList(int count)
        {
            Random random = new Random();
            for(int i = 0; i < count; i++)
            {
                string aux;
                int countAux = _listOptions.Count - 1;
                int selection = random.Next(0, countAux);
                aux = _listOptions[selection];
                _listOptions[selection] = _listOptions[^1];
                _listOptions[^1] = aux;
            }
        }

        public string GetFirstElement()
        {
            string result = _listOptions[0];
            _listOptions.RemoveAt(0);
            return result;
        }

    }
}
