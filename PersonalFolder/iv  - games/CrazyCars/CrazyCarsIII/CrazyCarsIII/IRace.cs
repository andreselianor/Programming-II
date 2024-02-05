using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyCarsIII
{
    public interface IRace
    {
        void StartRace(double distance);
        List<RaceObject> Simulate();
        RaceObject GetObjectAt(int index);
        int GetObjectCount();
    }
}
