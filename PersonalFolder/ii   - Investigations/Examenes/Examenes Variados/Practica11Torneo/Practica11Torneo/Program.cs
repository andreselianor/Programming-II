namespace Practica11Torneo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**TORNEO DE ARTES MARCIALES**");

            List<Persona.Humano> l = new List<Persona.Humano>();
            
            Tournament Torneo = new Tournament();

            Torneo.InitTournament();

            Console.WriteLine(Torneo);

            foreach(Persona.Humano players in Torneo.Lista)
            {
                Console.WriteLine(players.Name);
            }


        }
    }
}