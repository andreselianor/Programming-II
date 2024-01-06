namespace ExercismII
{
    public static class ScrabbleGame
    {
        public static int Score(string input)
        {
            int result = 0;

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            List<char> listCountValue1 = new List<char>()
            {
                'a',
                'e',
                'i',
                'o',
                'u',
                'l',
                'n',
                'r',
                's',
                't'
            };

            List<char> listCountValue2 = new List<char>()
            {
                'd',
                'g'
            };

            List<char> listCountValue3 = new List<char>()
            {
                'b',
                'c',
                'm',
                'p'
            };

            List<char> listCountValue4 = new List<char>()
            {
                'f',
                'h',
                'v',
                'w',
                'y'
            };

            List<char> listCountValue5 = new List<char>()
            {
                'k'
            };

            List<char> listCountValue8 = new List<char>()
            {
                'j',
                'x'
            };

            List<char> listCountValue10 = new List<char>()
            {
                'q',
                'z'
            };

            for (int i = 0; i < listCountValue1.Count; i++)
            {
                char letter = listCountValue1[i];
                dictionary[letter] = 1;
            }
            for (int i = 0; i < listCountValue2.Count; i++)
            {
                char letter = listCountValue2[i];
                dictionary[letter] = 2;
            }

            for (int i = 0; i < listCountValue3.Count; i++)
            {
                char letter = listCountValue3[i];
                dictionary[letter] = 3;
            }

            for (int i = 0; i < listCountValue4.Count; i++)
            {
                char letter = listCountValue4[i];
                dictionary[letter] = 4;
            }

            for (int i = 0; i < listCountValue5.Count; i++)
            {
                char letter = listCountValue5[i];
                dictionary[letter] = 5;
            }

            for (int i = 0; i < listCountValue8.Count; i++)
            {
                char letter = listCountValue8[i];
                dictionary[letter] = 8;
            }

            for (int i = 0; i < listCountValue10.Count; i++)
            {
                char letter = listCountValue10[i];
                dictionary[letter] = 10;
            }


            foreach (char c in input)
            {
                result += dictionary[c];
            }

            return result;
        }
    }
}
