namespace Grafico1
{
    public class World
    {
        // EL MUNDO TIENE ACTERS, OBJECTS, ENVIRONMENT, LANDSCAPE

        public Acters acters = new Acters();
        /*        
        public Objects objects;
        public Environment environment;
        public Landscape landscape;
        */

        // Creo que esto esta mal 
        public List<Character> listActers = new List<Character>();        

        public void CreateActers()
        {
            // Crea el Objeto de ACTERS
            acters.CreateCharacter(1,1,4);

            // DUDA!!!
            // listaActers - listaCharacter - Acceder al objeto acters
            // acters.ListPolice;????

            // Introduce TODOS los objetos Acters dentro de la lista COMUN
            for(int i = 0; i < acters.ListPolice.Count; i++)
            {
                listActers.Add(acters.ListPolice[i]);
            }

            for (int i = 0; i < acters.ListMinion.Count; i++)
            {
                listActers.Add(acters.ListMinion[i]);
            }

            for (int i = 0; i < acters.ListBoss.Count; i++)
            {
                listActers.Add(acters.ListBoss[i]);
            }
        }

        // ESTO ES UTIL, PERO ES CORRECTO???
        public List<Character> GetPoliceList()
        {
            return acters.ListPolice;
        }
    }
}
