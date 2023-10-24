namespace Grafico1
{
    public class World
    {

        private double _widthWorld = 10.0;
        private double _heightWorld = 10.0;

        private int policeCount = 2;
        private int thiefCount = 4;
        private int bossCount = 1;

        public double WidthWorld => _widthWorld;
        public double HeightWorld => _heightWorld;


        public Actores actores = new Actores();       
        public List<Character> listActores = new List<Character>();

        public NoActores noActores = new NoActores();
        public List<NoActores> listNoActores = new List<NoActores>();

        // EL MUNDO TIENE ACTORES, NOACTORES, ITEMS, ENVIRONMENT, LANDSCAPE           

        public void CreateActers()
        {
            actores.CreateCharacter(policeCount, bossCount, thiefCount);

            // Introduce TODOS los objetos Acters dentro de la lista COMUN
            for (int i = 0; i < actores.ListPolice.Count; i++)
            {
                listActores.Add(actores.ListPolice[i]);
            }

            for (int i = 0; i < actores.ListThief.Count; i++)
            {
                listActores.Add(actores.ListThief[i]);
            }

            for (int i = 0; i < actores.ListBoss.Count; i++)
            {
                listActores.Add(actores.ListBoss[i]);
            }
        }

        // TODO: GETTERS DE LISTAS EN WORLD
        public List<Character> GetPoliceList()
        {
            return actores.ListPolice;
        }

        // ALTERNATIVA: 
        public List<Character>? GetTypeList(List<Character> list, CharacterType type)
        {
            if (list == null)
                return null;

            for(int i = 0; i < list.Count; i++)
            {
                // Funcion GetCharacterType();
            }
            return null;
        }

        /* NO COMPILA
        public void CreateQuieters(double x, double y)
        {
            NoActores q = new NoActores();
            listNoActores.CreateQuieters(x, y);
            listNoActores.Add(q);
        }
        */
    }
}
