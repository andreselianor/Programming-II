namespace Dolphin01
{
    public class Dolphin
    {
        public int posX;
        public string name = "";
        public void Move(int number)
        {
            posX += number;
        }

        public int GetXPosition()
        {
            return posX;
        }
    }
}
