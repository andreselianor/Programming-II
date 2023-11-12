using System.Collections.Generic;

namespace Grafico1
{
    public class Actores
    {
        // ATRIBUTOS: Listas de Personajes Actores
        private List<Character> listPolicePlayer = new List<Character>();
        private List<Character> listThiefMinion = new List<Character>();
        private List<Character> listBossEnemy = new List<Character>();

        // GETTERS de las listas de Acters
        public List<Character> ListPolice => listPolicePlayer;
        public List<Character> ListThief => listThiefMinion;
        public List<Character> ListBoss => listBossEnemy;

        // METODO que CREA los personajes y los añade a las listas
        public void CreateCharacter(int policeNumber, int bossNumber, int thiefNumber)
        {
            for (int i = 0; i < policeNumber; i++)
            {
                Character Player = new Character(CharacterType.PLAYER, 9 - (i * 9), 9);
                listPolicePlayer.Add(Player);
            }

            for (int i = 0; i < bossNumber; i++)
            {
                Character Boss = new Character(CharacterType.BOSS, 5, 0);
                listBossEnemy.Add(Boss);
            }

            for (int i = 0; i < thiefNumber; i++)
            {
                int thiefPositionX = (i * 2) + 1;
                int thiefPositionY = 1;
                Character Thief = new Character(CharacterType.THIEF, thiefPositionX, thiefPositionY);
                listThiefMinion.Add(Thief);
            }
        }
    }
}
