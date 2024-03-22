namespace Delegado3
{
    public delegate bool DelegateMajor(int number);
    public delegate void DelegateText();

    public class Functions
    {
        public string word = "";
        public int countA;
        public int countN;
        public int countI;

        public static bool IsMajor5(int number)
        {
            return number > 5;
        }

        public Functions (string text)
        {
            word = text;
            countA = 0;
            countN = 0;
            countI = 0;
        }

        public void CountLetters()
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                    countA++;
                if (word[i] == 'n')
                    countN++;
                if (word[i] == 'i')
                    countI++;
            }
        }

        public void DelegateMethod()
        {
            DelegateText delegado = new DelegateText(CountLetters);
            delegado();
        }
    }
}
