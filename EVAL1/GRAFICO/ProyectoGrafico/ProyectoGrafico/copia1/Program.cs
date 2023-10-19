using OpenTK.Core;
using UDK;

namespace ProyectoGrafico
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MyGame game = new MyGame();

            UDK.Game.Launch(game);
        }
    }

    public class Character
    {
        public double x;
        public double y;
        public double colorR = 0.0;
        public double colorG = 0.0;
        public double colorB = 1.0;
    }


    public class MyGame : UDK.IGameDelegate
    {
        double x = 0;
        double y = 0;
        Character Player1;
        Character Enemy1;
        List<Character> EnemyCharacters;


        public void OnLoad(GameDelegateEvent gameEvent)
        {
            Player1 = new Character();
            Player1.x = 50;
            Player1.y = 50;


            Enemy1 = new Character();
            Enemy1.x = 10;
            Enemy1.y = 10;

            EnemyCharacters = new List<Character>();

            EnemyCharacters.Add(new Character());
            EnemyCharacters.Add(new Character());
            EnemyCharacters.Add(new Character());
            EnemyCharacters.Add(new Character());

            for(int i = 0; i < EnemyCharacters.Count; i++)
            {
                EnemyCharacters[i].x = Utils.GetRandomDouble(0, 50);
                EnemyCharacters[i].y = Utils.GetRandomDouble(0, 50);
            }
            
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyUp(Keys.Right))
                Player1.x -= 0.01;
            if (keyboard.IsKeyUp(Keys.Left))
                Player1.x += 0.01;
            if (keyboard.IsKeyUp(Keys.Up))
                Player1.y -= 0.01;
            if (keyboard.IsKeyUp(Keys.Down))
                Player1.y += 0.01;

        }


        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            double movementx = Utils.GetRandomDouble(0,0.5);
            double movementy = Utils.GetRandomDouble(0, 0.5);
            Enemy1.x = movementx;
            Enemy1.y = movementy;

            for(int i = 0; i < EnemyCharacters.Count; i++)
            {
                EnemyCharacters[i].x = movementx;
                EnemyCharacters[i].y = movementy;
            }
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
                                                                    // Luces de color
            canvas.Clear(0.0,0.0,0.0,1.0);                          // Limpiar el canvas
            canvas.Camera.SetRectangle(0, 0, 100, 100);               // Colocar la camara del canvas

            canvas.FillShader.SetColor(1.0, 0.0, 0.0, 1.0);                              // Color del Camera 
            canvas.DrawRectangle(Enemy1.x + 30, Enemy1.y + 30, 5, 5);                       // rectangulo

            canvas.FillShader.SetColor(Player1.colorR, Player1.colorG, Player1.colorB, 1.0);
            canvas.DrawRectangle(Player1.x, Player1.y, 5, 5);

            for (int i = 0; i < EnemyCharacters.Count; i++)
            {                
                canvas.FillShader.SetColor(0.0, 1.0, 0.0, 1.0);
                canvas.DrawRectangle(EnemyCharacters[i].x, EnemyCharacters[i].y, 5, 5);
                
            }
            
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}