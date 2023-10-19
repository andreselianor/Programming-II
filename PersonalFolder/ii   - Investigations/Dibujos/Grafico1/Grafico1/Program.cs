using System;
using UDK;

namespace Grafico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGame game = new MyGame();
            UDK.Game.Launch(game);
        }
    }

    public class MyGame : UDK.IGameDelegate
    {

        double width = 10.0;
        double height = 10.0;

        Character Player1;
        Character Thief;
        List<Character> _listMinion;

        Character Minion1;
        Character Minion2;
        Character Minion3;

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            Player1 = new Character();
            Player1.posX = width / 2;
            Player1.posY = height / 2;

            Thief = new Character();
            Thief.posX = 2.0;
            Thief.posY = 2.0;

            _listMinion = new List<Character>();
            Minion1 = new Character();
            Minion2 = new Character();
            Minion3 = new Character();

            _listMinion.Add(Minion1);
            _listMinion.Add(Minion2);
            _listMinion.Add(Minion3);

            for (int i = 0; i < _listMinion.Count; i++)
            {
                _listMinion[i].posX = Utils.GetRandom(0, width);
                _listMinion[i].posY = Utils.GetRandom(0, height);
            }
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {            
            Thief.posX = Utils.GetRandom(1, 1.2);
            Thief.posY = Utils.GetRandom(1, 1.2);
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            // Canvas
            canvas.Clear(0.0, 0.0, 0.0, 1.0);
            canvas.Camera.SetRectangle(0, 0, width, height);

            // Police
            canvas.FillShader.SetColor(0.0, 0.0, 1.0, 1.0);
            canvas.DrawRectangle(Player1.posX,Player1.posY,Player1.characterWidth, Player1.characterHeight);

            // ThiefBoss
            canvas.FillShader.SetColor(1.0, 0.0, 0.0, 1.0);
            canvas.DrawRectangle(Thief.posX, Thief.posY, Thief.characterWidth, Thief.characterHeight);

            // Minions
            canvas.FillShader.SetColor(0.0, 1.0, 1.0, 1.0);
            
            for (int i = 0; i < _listMinion.Count; i++)
            {
                canvas.DrawRectangle(_listMinion[i].posX, _listMinion[i].posY,
                                     _listMinion[i].characterWidth, _listMinion[i].characterHeight);
            }
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Up))            
                Player1.posY += 0.01;            

            if (keyboard.IsKeyDown(Keys.Down))            
                Player1.posY -= 0.01;            

            if (keyboard.IsKeyDown(Keys.Right))            
                Player1.posX += 0.01;            

            if (keyboard.IsKeyDown(Keys.Left))            
                Player1.posX -= 0.01;            
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }

    public class Character
    {
        public double posX;
        public double posY;

        public double characterWidth = 1;
        public double characterHeight = 1;
    }

    public class Utils
    {
        private static Random random = new Random();
        public static double GetRandom(double min, double max)
        {
            return (min + random.NextDouble() * (max - min));
        }

        public static int GetIntRandom(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}