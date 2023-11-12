using System.Drawing;
using UDK;

namespace Grafico1
{
    public class World
    {
        public Rectangle rectangle;

        private double[] WorldColor = new double[]
        {
            0.2,    
            0.8,    
            0.4,
            0.2
        };

        private int policeCount = 2;
        private int thiefCount = 4;
        private int bossCount = 1;
              
        public Actores actores = new Actores();       
        public List<Character> listActores = new List<Character>();

        public NoActores noActores = new NoActores();
        public List<NoActores> listNoActores = new List<NoActores>();


        public void CreateWorld(double widthWorld, double heightWorld)
        {
            rectangle = new Rectangle(0, 0, widthWorld, heightWorld);
        }

        public void DrawWorld(ICanvas canvas)
        {
            canvas.FillShader.SetColor(WorldColor[0], WorldColor[1], WorldColor[2], WorldColor[3]);
            canvas.DrawRectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

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

        public bool HasPlayerReachLimit(Character character)
        {
            Rectangle limitWorld = new Rectangle();
            limitWorld = rectangle;

            Rectangle reference = new Rectangle();
            reference = character.rectangle;

            if (reference.X <= -1 || reference.X >= limitWorld.Width)
                return true;
            if (reference.Y <= -1 || reference.Y >= limitWorld.Height)
                return true;

            return false;
        }

        /* NO COMPILA
        public void CreateQuieters(double x, double y)
        {
            NoActores q = new NoActores();
            listNoActores.CreateBombs(x, y);
            listNoActores.Add(q);
        }
        */
    }
}
