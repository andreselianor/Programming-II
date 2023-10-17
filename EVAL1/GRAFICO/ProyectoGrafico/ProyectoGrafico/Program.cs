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


    public class MyGame : UDK.IGameDelegate
    {

        double U = 0.0;

        public void OnLoad(GameDelegateEvent gameEvent)
        {
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
        }


        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            //U = Utils.SetRandom();                                // Luces de color
            canvas.Clear(0.0,0.0,0.0,1.0);                        // Limpiar el canvas
            canvas.Camera.SetRectangle(0, 0, 10, 10);  
            // Colocar la camara del canvas
            canvas.FillShader.SetColor(1.0, 0.0, 0.0, 1.0);       // Color del Camera 
            canvas.DrawRectangle(1, 1, 2, 2);                       // rectangulo
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}