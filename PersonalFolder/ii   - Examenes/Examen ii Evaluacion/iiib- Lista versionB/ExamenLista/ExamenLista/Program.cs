namespace ExamenLista
{
    internal class Program
    {
        public delegate void DelegateAlter(string text);
        static void Main(string[] args)
        {
            // TEST DELEGATES
            ExList<string> test = new ExList<string>();

            // Test declaracion de variables
            ExList<string>.DelegateFilter filter = new ExList<string>.DelegateFilter(text => text.Length > 3);
            {
                test = test.Filter(filter);
                test = test.Filter(text => text[^1] == 'a');
                test = test.Filter(text => { return char.IsLetter(text[0]); });
                test = test.Filter(text =>
                {
                    return char.IsSymbol(text[0]);
                });
            }            

            // Funciones anonimas
            // public delegate void DelegateAlter(string text);
            DelegateAlter delegado = delegate (string text) { int result = text[3]; };
            delegado("prueba test delegado");
            
        }
    }
}
