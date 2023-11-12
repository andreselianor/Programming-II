using UDK;

namespace Grafico1
{
    public enum CharacterType
    {
        PLAYER,
        THIEF,
        BOSS
    }
    public class Character
    {
        public double posX;
        public double posY;

        public double characterWidth = 1;
        public double characterHeight = 1;

        public CharacterType type;

        public double[] policeColor = new double[4]
        {
            0.2,
            0.2,
            1.0,
            0.8
        };

        public double[] thiefColor = new double[4]
        {
            0.2,
            0.8,
            0.2,
            0.8
        };
        public double[] bossColor = new double[4]
        {
            0.8,
            0.2,
            0.2,
            0.8
        };

        public double movement = 0;
        public double variation = 0;



        // GETTER
        public CharacterType GetCharacterType => type;



        // CONSTRUCTORES
        public Character()
        {

        }

        public Character(CharacterType typeValue, double positionXValue, double PositionYValue)
        {
            type = typeValue;
            posX = positionXValue;
            posY = PositionYValue;
        }


        // METODOS DE CLASE
        public void Draw(ICanvas canvas, CharacterType type)
        {
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
        }

        public void Move()
        {
            //movement += 1.0 / 1000.0;
            variation += 0.001;
            posX = Math.Sin(variation);            
        }
    }
}
