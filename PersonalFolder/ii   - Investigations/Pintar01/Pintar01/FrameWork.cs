﻿using UDK;

namespace Pintar01
{
    public class FrameWork : IGameDelegate
    {
        double r = 1.0;
        double g = 1.0;
        double b = 1.0;
        double a = 1.0;

        public Board board;
        public Element element1;
        public Element element2;
        public Element element3;
        public Element element4;

        public Element element1Shade;
        public Element element2Shade;
        public Element element3Shade;
        public Element element4Shade;

        public bool switchColor1 = false;
        public bool switchColor2 = false;
        public bool switchColor3 = false;
        public bool switchColor4 = false;


        int turn = 0;
        bool loveMeter = false;



        public void OnAnimate(GameDelegateEvent gameEvent)
        {


        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(r, g, b, a);
            canvas.Camera.SetRectangle(-1, -1, 10, 10);

            element1.DrawElements(canvas, 0, 0, 1);
            element2.DrawElements(canvas, 0, 0.5, 1);
            element3.DrawElements(canvas, 1.0, 1.0, 0.0);
            element4.DrawElements(canvas, 1.0, 0.0, 0.0);

            if (switchColor1)
                element1Shade.DrawElements(canvas, 1, 1, 1);

            if (switchColor2)
                element2Shade.DrawElements(canvas, 1, 1, 1);

            if (switchColor3)
                element3Shade.DrawElements(canvas, 1, 1, 1);

            if (switchColor4)
                element4Shade.DrawElements(canvas, 1, 1, 1);


            /*
            board.DrawLoveMeter(canvas, loveMeter);            
            board.DrawBoard(canvas, turn);
            */
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (mouse.IsDown(MouseButton.Button1) && mouse.X > 300 && mouse.Y < 300)
                switchColor1 = !switchColor1;
            if (mouse.IsDown(MouseButton.Button1) && mouse.X < 300 && mouse.Y < 300)
                switchColor2 = !switchColor2;
            if (mouse.IsDown(MouseButton.Button1) && mouse.X > 300 && mouse.Y > 300)
                switchColor3 = !switchColor3;
            if (mouse.IsDown(MouseButton.Button1) && mouse.X < 300 && mouse.Y > 300)
                switchColor4 = !switchColor4;
            

            /*
            if (mouse.Y > 300)
            {
                loveMeter = false;
            }
            if (mouse.Y < 300)
            {
                loveMeter = true;
            }
            if (mouse.IsDown(MouseButton.Button1))
            {
                turn++;
            }
            */

        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            board = new Board();
            element1 = new Element(7, 7, 1);
            element2 = new Element(0, 7, 1);
            element3 = new Element(7, 0, 1);
            element4 = new Element(0, 0, 1);

            element1Shade = new Element(7.1, 7.1, 0.8);
            element2Shade = new Element(0.1, 7.1, 0.8);
            element3Shade = new Element(7.1, 0.1, 0.8);
            element4Shade = new Element(0.1, 0.1, 0.8);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}
