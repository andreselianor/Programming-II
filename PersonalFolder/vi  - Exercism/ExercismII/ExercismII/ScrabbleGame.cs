namespace ExercismII
{
    public static class ScrabbleGame
    {
        public static int Score(string input)
        {
            int result = 0;

            Dictionary<char, int> letterScore = new Dictionary<char, int>();

            List<char> listLetterPuntuation1 = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'
            };

            foreach(char letter in listLetterPuntuation1)
            {
                letterScore[letter] = 1;
            }

            List<char> listLetterPuntuation2 = new List<char>()
            {
                'd', 'g'
            };

            foreach (char letter in listLetterPuntuation2)
            {
                letterScore[letter] = 2;
            }

            List<char> listLetterPuntuation3 = new List<char>()
            {
                'b', 'c', 'm', 'p'
            };

            foreach (char letter in listLetterPuntuation3)
            {
                letterScore[letter] = 3;
            }

            List<char> listLetterPuntuation4 = new List<char>()
            {
                'f', 'h', 'v', 'w', 'y'
            };

            foreach (char letter in listLetterPuntuation4)
            {
                letterScore[letter] = 4;
            }

            List<char> listLetterPuntuation5 = new List<char>()
            {
                'k'
            };

            foreach (char letter in listLetterPuntuation5)
            {
                letterScore[letter] = 5;
            }

            List<char> listLetterPuntuation8 = new List<char>()
            {
                'j', 'x'
            };

            foreach (char letter in listLetterPuntuation8)
            {
                letterScore[letter] = 8;
            }

            List<char> listLetterPuntuation10 = new List<char>()
            {
                'q', 'z'
            };

            foreach (char letter in listLetterPuntuation10)
            {
                letterScore[letter] = 10;
            }

            foreach (char c in input)
            {
                result += letterScore[c];
            }

            return result;
        }
    }
}
