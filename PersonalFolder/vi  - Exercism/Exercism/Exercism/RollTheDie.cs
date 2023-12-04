namespace Exercism
{
    public class RollTheDie
    {
        private Random random = new Random();

        public int RollDie() => random.Next(1, 19);

        public double GenerateSpellStrength() => random.NextDouble() * 100.0;
    }
}
