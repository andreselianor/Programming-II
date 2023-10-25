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
        Character Player1;
        Character Player2;
        NoActores Bombs;

        public List<Character> listPolice;
        public List<Character> listBoss;
        public List<Character> listThief;
        public List<Character> listBombs;


        public void OnLoad(GameDelegateEvent gameEvent)
        {
            world = new World();

            double worldWidth = 11;
            double worldHeight = 10;

            world.CreateWorld(worldWidth, worldHeight);
            world.CreateActers();
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {

            canvas.Clear(r, g, b, 1.0);
            canvas.Camera.SetRectangle(-1, -1, 12, 12);

            // World
            world.DrawWorld(canvas);

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

            // Bombs
            listBombs = world.bombs.ListBombs;
            for (int i = 0; i < listBombs.Count; i++)
            {
                listBombs[i].Draw(canvas);
            }
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            listPolice = world.actores.ListPolice;
            listThief = world.actores.ListThief;
            listBombs = world.bombs.ListBombs;

            // MOVEMENT
            for (int i = 0; i < listThief.Count; i++)
                listThief[i].MoveIA();


            // CHASING THIEFS
            if (listBombs.Count > 0)
                if (listBombs[0].rectangle.IntersectionRectangle(listThief[0].rectangle))
                    listThief[0].DeleteThief();

        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            // PLAYER 1
            Player1 = world.GetPoliceList()[0];

            if (keyboard.IsKeyDown(Keys.Up))
            {
                if (world.HasPlayerReachLimit(Player1))
                    Player1.rectangle.Y = 9.00;
                else
                    Player1.MovePlayer(false, true, 0.01);
            }

            if (keyboard.IsKeyDown(Keys.Down))
            {
                if (world.HasPlayerReachLimit(Player1))
                    Player1.rectangle.Y = 0.00;
                else
                    Player1.MovePlayer(false, false, 0.01);
            }

            if (keyboard.IsKeyDown(Keys.Right))
            {
                if (world.HasPlayerReachLimit(Player1))
                    Player1.rectangle.X = 10.00;
                else
                    Player1.MovePlayer(true, true, 0.01);
            }

            if (keyboard.IsKeyDown(Keys.Left))
            {
                if (world.HasPlayerReachLimit(Player1))
                    Player1.rectangle.X = 0.00;
                else
                    Player1.MovePlayer(true, false, 0.01);
            }

            if (keyboard.IsKeyDown(Keys.Space))
            {
                world.CreateNonActors(Player1.rectangle.X, Player1.rectangle.Y, 1, 1);
            }

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
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}
