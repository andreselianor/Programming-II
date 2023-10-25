using UDK;

namespace Grafico1
{
    public enum CharacterType
    {
        PLAYER,
        THIEF,
        BOSS,
        BOMB
    }
    public class Character
    {
        public Rectangle rectangle = new Rectangle();
        public CharacterType type;
        public double velocity = 1;

        private double[] policeColor = new double[4]
        {
            0.2,
            0.2,
            1.0,
            0.8
        };

        private double[] thiefColor = new double[4]
        {
            0.2,
            0.8,
            0.2,
            0.8
        };
        private double[] bossColor = new double[4]
        {
            0.8,
            0.2,
            0.2,
            0.8
        };
        private double[] bombColor = new double[4]
        {
            0.8,
            0.8,
            0.1,
            0.8
        };


        #region Constructores
        public Character()
        {

        }

        public Character(CharacterType typeValue,
                        double positionXValue, double positionYValue,
                        double widthValue, double heightValue)
        {
            type = typeValue;
            rectangle.X = positionXValue;
            rectangle.Y = positionYValue;
            rectangle.SetWidth(widthValue);
            rectangle.SetHeight(heightValue);
        }
        #endregion


        #region Metodos
        public void Draw(ICanvas canvas)
        {
            double posX = rectangle.X;  // TODO:DUDA DE VARIABLES
            double posY = rectangle.Y;
            double characterWidth = rectangle.Width;
            double characterHeight = rectangle.Height;

            if (type == CharacterType.PLAYER)
            {
                canvas.FillShader.SetColor(policeColor[0], policeColor[1], policeColor[2], policeColor[3]);
                canvas.DrawRectangle(posX, posY, characterWidth, characterHeight);
            }

            if (type == CharacterType.THIEF)
            {
                canvas.FillShader.SetColor(thiefColor[0], thiefColor[1], thiefColor[2], thiefColor[3]);
                canvas.DrawRectangle(posX, posY, characterWidth, characterHeight);
            }

            if (type == CharacterType.BOSS)
            {
                canvas.FillShader.SetColor(bossColor[0], bossColor[1], bossColor[2], bossColor[3]);
                canvas.DrawRectangle(posX, posY, characterWidth, characterHeight);
            }

            if (type == CharacterType.BOMB)
            {
                canvas.FillShader.SetColor(bombColor[0], bombColor[1], bombColor[2], bombColor[3]);
                canvas.DrawRectangle(posX, posY, characterWidth, characterHeight);
            }
        }

        public void MovePlayer(bool horizontal, bool vertical, double value)
        {
            if (!horizontal && vertical)
                rectangle.Y += value;

            if (!horizontal && !vertical)
                rectangle.Y -= value;

            if (horizontal && vertical)
                rectangle.X += value;

            if (horizontal && !vertical)
                rectangle.X -= value;
        }
        public void MoveIA()
        {
            velocity += 0.001;
            rectangle.Y = (Math.Sin(velocity) * 4) + 5;

        }

        public void DeleteThief()
        {
            /*
            double eraser = 0.001;
            eraser -= velocity;
            */
            rectangle.SetWidth(0.01);
        }
        #endregion
    }
}
