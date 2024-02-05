using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyCarsIII
{
    public class Race : IRace
    {
        private List<RaceObject> listObjects = new List<RaceObject>();
        private double _distance;

        public List<RaceObject> Simulate()
        {
            return listObjects;
        }

        public RaceObject GetObjectAt(int index)
        {
            return listObjects[index];
        }

        public int GetObjectCount()
        {
            return listObjects.Count;
        }

        public void StartRace(double distance)
        {
            _distance = distance;
        }
    }
}
