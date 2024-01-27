namespace ExercismII
{
    public class Acronym
    {
        // Funcion que extrae el acronimo de una frase.
        public static string Abbreviate(string phrase)
        {
            string result = "" + phrase[0];

            for (int i = 1; i < phrase.Length - 1; i++)
            {
                if (IsLetter(phrase[i]) && !IsMayus(phrase[i - 1]))
                {
                    if (i > 0 && IsSpace(phrase[i - 1]))
                        result += phrase[i];
                    else if (i > 0 && IsSign(phrase[i - 1]))
                        result += phrase[i];
                    else if (IsMayus(phrase[i]))
                        result += phrase[i];
                }
            }

            return result.ToUpper();
        }

        // Funcion que devuelve verdadero si la letra es mayuscula.
        public static bool IsMayus(char letter)
        {
            return (64 < letter && letter < 91);
        }

        // Funcion que devuelve verdadero si la letra es un signo.
        public static bool IsSign(char letter)
        {
            return !char.IsLetter(letter) && letter != 39;
        }

        // Funcion que devuelve verdadero si la letra es un espacio.
        public static bool IsSpace(char letter)
        {
            return letter == 32;
        }

        // Funcion que devuelve verdadero si el caracter es una letra.
        public static bool IsLetter(char letter)
        {
            return char.IsLetter(letter);
        }
    }
}