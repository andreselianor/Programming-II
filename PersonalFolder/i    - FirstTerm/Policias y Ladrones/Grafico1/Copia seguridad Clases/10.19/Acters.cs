using System.Collections.Generic;

namespace Grafico1
{
    public class Acters
    {
        // ATRIBUTOS: Listas de Personajes Actores
        public List<Character> listPolicePlayer = new List<Character>();
        public List<Character> listThiefMinion = new List<Character>();
        public List<Character> listBossEnemy = new List<Character>();



        // GETTERS de las listas de Acters
        public List<Character> ListPolice => listPolicePlayer;
        public List<Character> ListMinion => listThiefMinion;
        public List<Character> ListBoss => listBossEnemy;



        // METODO que CREA los personajes y los añade a las listas
        public void CreateCharacter(int policeNumber, int bossNumber, int thiefNumber)
        {
            for (int i = 0; i < policeNumber; i++)
            {
                Character Player = new Character(CharacterType.PLAYER, 5, 5);
                listPolicePlayer.Add(Player);
            }

            for (int i = 0; i < bossNumber; i++)
            {
                Character Boss = new Character(CharacterType.BOSS, 0, 0);
                listBossEnemy.Add(Boss);
            }

            for (int i = 0; i < thiefNumber; i++)
            {
                int thiefPositionX = Utils.GetIntRandom(0, 10);
                int thiefPositionY = Utils.GetIntRandom(0, 10);
                Character Thief = new Character(CharacterType.THIEF, thiefPositionX, thiefPositionY);
                listThiefMinion.Add(Thief);
            }
        }
    }
}
