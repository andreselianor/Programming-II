namespace ExercismII
{
    public static class RotationalCipher
    {
        // Funcion que devuelve una cadena de texto codificada.
        public static string Rotate(string text, int shiftKey)
        {
            string result = "";
            char letter = ' ';

            if (shiftKey == 0)
                return text;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 96 && text[i] < 123)
                {
                    letter = text[i];
                    letter += (char)shiftKey;

                    if (letter > 122)
                        letter = (char)(letter - 26);

                    result += letter;
                }

                else if (text[i] > 65 && text[i] < 91)
                {
                    letter = text[i];
                    letter += (char)shiftKey;

                    if (letter > 91)
                        letter = (char)(letter - 26);

                    result += letter;
                }

                else
                {
                    letter = text[i];
                    result += letter;
                }
            }
            return result;
        }
    }
}

