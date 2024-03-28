using System;

namespace MedievalGame
{
    public class Warzone
    {
        private int _width;
        private int _height;
        private List<Warrior> _warriorList = new List<Warrior>();
        private int _isPlayerDefeated;

        public Warzone(int x, int y)
        {
            _width = x;
            _height = y;
        }        

        public int GetWarriorListCount()
        {
            return _warriorList.Count;
        }

        public Warrior GetWarriorAt(int index)
        {
            return _warriorList[index];
        }

        public Warrior GetWarriorAt(int x, int y)
        {
            Warrior warrior = new Warrior();
            for (int i = 0; i < _warriorList.Count; i++)
            {
                if (warrior.X == x && warrior.Y == y)
                    return _warriorList[i];
            }
            return null;
        }

        public void RemoveWarriorAt(int index)
        {
            _warriorList.RemoveAt(index);
        }

        public void RemoveWarriorAtPosition(int x, int y)
        {
            Warrior warrior = new Warrior();
            for (int i = 0; i < _warriorList.Count; i++)
            {
                if (warrior.X == x && warrior.Y == y)
                    _warriorList.RemoveAt(i);
            }
        } 

        public List<Warrior> GetWarriorList()
        {
            return _warriorList;
        }

        public int GetWarriorsAlive()
        {
            return _warriorList.Count;
        }
    }
}
