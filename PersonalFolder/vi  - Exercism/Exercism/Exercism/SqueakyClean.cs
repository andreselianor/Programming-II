using System;
using System.Text;

namespace Exercism
{
    public static class Identifier
    {
        public static string Clean(string identifier)
        {
            StringBuilder stringBuilder = new StringBuilder(identifier);
            stringBuilder.Replace(' ', '_');

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (char.IsControl(stringBuilder[i]))
                    stringBuilder.Replace("" + stringBuilder[i], "CTRL");

                else if (stringBuilder[i] == '-')
                {
                    stringBuilder.Remove(i, 1);
                    stringBuilder[i] = char.ToUpper(stringBuilder[i]);
                    i--;
                }

                else if (stringBuilder[i] > 47 && stringBuilder[i] < 58)
                {
                    stringBuilder.Remove(i, 1);
                    i--;
                }

                else if (stringBuilder[i] >= 'α' && stringBuilder[i] <= 'ω')
                {
                    stringBuilder.Remove(i, 1);
                    i--;
                }

                else if (!char.IsLetter(stringBuilder[i]) && stringBuilder[i] != '_')
                {
                    stringBuilder.Remove(i, 1);
                    i--;
                }
            }

            return stringBuilder.ToString();
        }
    }
}

