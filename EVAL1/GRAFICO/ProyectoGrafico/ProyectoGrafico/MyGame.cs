using UDK;

namespace Grafico1
{
    public class MyGame : UDK.IGameDelegate
    {

        // ATRIBUTOS DE GAME

        double widthCanvas = 10.0;
        double heightCanvas = 10.0;

        double r = 1.0;
        double g = 1.0;
        double b = 1.0;

        CharacterType drawType;

        List<Character> movingList;

        World world;

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            world = new World();
            world.CreateActers();
            //world.CreateObjects();
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            for (int i = 0; i < world.acters.ListMinion.Count; i++)
            {
                drawType = world.acters.ListMinion[i].GetCharacterType;
                world.acters.ListMinion[i].Move();
            }
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            // Canvas
            canvas.Clear(r, g, b, 1.0);
            canvas.Camera.SetRectangle(0, 0, widthCanvas, heightCanvas);


            // Police
            // Mejor con un getter de Policias??? Mas abajo
            drawType = world.acters.ListPolice[0].GetCharacterType;
            world.acters.ListPolice[0].Draw(canvas, drawType);            


            // Boss
            drawType = world.acters.ListBoss[0].GetCharacterType;
            world.acters.ListBoss[0].Draw(canvas, drawType);


            // Minions
            // UNA SOLUCION MEJOR PARA EL FOR QUE PINTA TODOS LOS LADRONES
            for (int i = 0; i < world.acters.ListMinion.Count; i++)
            {
                drawType = world.acters.ListMinion[i].GetCharacterType;
                world.acters.ListMinion[i].Draw(canvas, drawType);
            }

        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {            
            movingList = world.GetPoliceList();

            if (keyboard.IsKeyDown(Keys.Up))
                movingList[0].posY += 0.01;

            if (keyboard.IsKeyDown(Keys.Down))
                movingList[0].posY -= 0.01;

            if (keyboard.IsKeyDown(Keys.Right))
                movingList[0].posX += 0.01;

            if (keyboard.IsKeyDown(Keys.Left))
                movingList[0].posX -= 0.01;            
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}
