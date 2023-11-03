using UDK;

namespace Pintar01
{
    public class Board
    {
        public double x = 10;
        public double y = 10;

        public double r = 0.5;
        public double g = 0.0;
        public double b = 0.5;
        public double a = 0.5;

        public double xLove = 1;
        public double yLove = 10;

        public double rLove = 1.0;
        public double gLove = 0.0;
        public double bLove = 1.0;
        public double aLove = 0.8;

        public void DrawBoard(ICanvas canvas)
        {
            canvas.FillShader.SetColor(1, 0, 0, a);
            canvas.DrawRectangle(0, 0, x / 2, y / 2);

            canvas.FillShader.SetColor(0, 1, 0, a);
            canvas.DrawRectangle(x / 2, 0, x / 2, y / 2);

            canvas.FillShader.SetColor(0, 0, 1, a);
            canvas.DrawRectangle(0, y / 2, x / 2, y / 2);

            canvas.FillShader.SetColor(r, g, b, a);
            canvas.DrawRectangle(x / 2, y / 2, x / 2, y / 2);
        }

        public void DrawBoard(ICanvas canvas, int turn)
        {
            if(turn == 1)
            {
                canvas.FillShader.SetColor(1, 0, 0, 1.0);
                canvas.DrawRectangle(0, 0, x / 2, y / 2);
            }
            else
            {
                canvas.FillShader.SetColor(1, 0, 0, a);
                canvas.DrawRectangle(0, 0, x / 2, y / 2);
            }
                
                
                
            
        }

        public void DrawLoveMeter(ICanvas canvas, bool upDown)
        {
            if (upDown)
            {
                canvas.FillShader.SetColor(rLove, gLove, bLove, aLove);
                canvas.DrawRectangle(-1.5, 0, xLove, yLove);
            }

            else
            {
                canvas.FillShader.SetColor(0.0, 0.0, 0.0, 1.0);
                canvas.DrawRectangle(-1.5, 0, xLove, yLove);
            }
        }
    }
}
