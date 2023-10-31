namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Card card1 = new Card(1,Palo.PICA);
            bool try1 = card1.IsValid();

            Card card2 = new Card(-1, Palo.CORAZON);
            bool try2 = card2.IsValid();

            Card card3 = new Card(11, Palo.PICA);
            bool try3 = card3.IsValid();
            bool try4 = card3.IsFigure();
            TypeCard type = card3.GetFigureType();

            Card card4 = new Card(5, Palo.PICA);
            

        }
    }
}