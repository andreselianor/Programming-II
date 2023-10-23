using UDK;

namespace Grafico1
{
    public class MyGame : UDK.IGameDelegate
    {

        // ATRIBUTOS DE GAME
        double r = 1.0;
        double g = 1.0;
        double b = 1.0;

        World world;
        CharacterType drawType;
        Character Player1;
        Character Player2;

        public List<Character> listPolice;
        public List<Character> listBoss;
        public List<Character> listThief;


        public void OnLoad(GameDelegateEvent gameEvent)
        {
            world = new World();
            world.CreateActers();
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            // World
            canvas.Clear(r, g, b, 1.0);
            canvas.Camera.SetRectangle(0, 0, world.WidthWorld, world.HeightWorld);

            // Police
            listPolice = world.actores.ListPolice;
            for (int i = 0; i < listPolice.Count; i++)
            {
                listPolice[i].Draw(canvas);
            }

            // Boss
            listBoss = world.actores.ListBoss;
            for (int i = 0; i < listBoss.Count; i++)
            {
                listBoss[i].Draw(canvas);
            }

            // Thiefs
            listThief = world.actores.ListThief;
            for (int i = 0; i < listThief.Count; i++)
            {
                listThief[i].Draw(canvas);
            }
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            // MOVEMENT
            listThief = world.actores.ListThief;
            for (int i = 0; i < listThief.Count; i++)
            {
                listThief[i].Move();
            }

            // CHASING INTERSECTION
            listPolice = world.actores.ListPolice;
            listPolice[0].rectangle.IntersectionRectangle(listThief[0].rectangle);

            if (listPolice[0].rectangle.IntersectionRectangle(listThief[0].rectangle))
            {
                listThief[0].rectangle.Width *= 9.9 / 10.0;
                listThief[0].rectangle.Height *= 9.9 / 10.0;
            }
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            // PLAYER 1
            Player1 = world.GetPoliceList()[0];

            if (keyboard.IsKeyDown(Keys.Up))
                Player1.rectangle.Y += 0.01;

            if (keyboard.IsKeyDown(Keys.Down))
                Player1.rectangle.Y -= 0.01;

            if (keyboard.IsKeyDown(Keys.Right))
                Player1.rectangle.X += 0.01;

            if (keyboard.IsKeyDown(Keys.Left))
                Player1.rectangle.X -= 0.01;

            if (keyboard.IsKeyDown(Keys.Space))           


            // PLAYER 2
            Player2 = world.GetPoliceList()[1];         // TODO: PROBLEMA DE ACCESO AL INDEX 1

            if (keyboard.IsKeyDown(Keys.W))
                Player2.rectangle.Y += 0.01;

            if (keyboard.IsKeyDown(Keys.S))
                Player2.rectangle.Y -= 0.01;

            if (keyboard.IsKeyDown(Keys.D))
                Player2.rectangle.X += 0.01;

            if (keyboard.IsKeyDown(Keys.A))
                Player2.rectangle.X -= 0.01;

            // CREAR UNA BOMBA
            //world.CreateQuieters(Player1.rectangle.X, Player1.rectangle.Y);

        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}
