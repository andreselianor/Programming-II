namespace Grafico1
{
    public class NoActores
    {
        List<Character> listBombs = new List<Character>();
        Character bomb;

        public List<Character> ListBombs => listBombs;
        public void CreateBombs(double x, double y, double width, double height)
        {
            bomb = new Character(CharacterType.BOMB,x, y, width, height);
            listBombs.Add(bomb);
        }
    }
}
