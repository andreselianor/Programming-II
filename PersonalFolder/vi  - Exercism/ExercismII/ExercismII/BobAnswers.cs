namespace ExercismII
{
    public enum ResponseType
    {
        SILENCE,
        QUESTION,
        YELL,
        QUESTIONYELL,
        OTHER
    }

    public static class Bob
    {
        // La funcion devuelve una respuesta, segun el tipo de pregunta que se realiza.
        public static string Response(string statement)
        {
            ResponseType response = StatementType(statement);

            if (response == ResponseType.SILENCE)
                return "Fine. Be that way!";

            if (response == ResponseType.YELL)
                return "Whoa, chill out!";

            if (response == ResponseType.QUESTION)
                return "Sure.";

            if (response == ResponseType.QUESTIONYELL)
                return "Calm down, I know what I'm doing!";

            return "Whatever.";
        }

        // La funcion devuelve un tipo de pregunta, segun la sintaxis de la frase.
        public static ResponseType StatementType(string statement)
        {
            if (statement == "")
                return ResponseType.SILENCE;

            if (ContainsLetters(statement) == false)
            {
                if (statement[^1] == '?')
                    return ResponseType.QUESTION;

                else if (statement[^1] > 48 && statement[^1] < 58)
                    return ResponseType.OTHER;

                else
                    return ResponseType.SILENCE;
            }

            if (statement == statement.ToUpper())
            {
                if (statement[^1] == '?')
                    return ResponseType.QUESTIONYELL;

                else
                    return ResponseType.YELL;
            }

            if (statement[^1] == '?')
                return ResponseType.QUESTION;

            if (statement.Trim()[^1] == '?')
                return ResponseType.QUESTION;

            return ResponseType.OTHER;
        }

        // Funcion que devuelve verdadero si la frase contiene alguna letra.
        public static bool ContainsLetters(string statement)
        {
            for (int i = 0; i < statement.Length; i++)
            {
                if (char.IsLetter(statement[i]) == true)
                    return true;
            }
            return false;
        }
    }
}
