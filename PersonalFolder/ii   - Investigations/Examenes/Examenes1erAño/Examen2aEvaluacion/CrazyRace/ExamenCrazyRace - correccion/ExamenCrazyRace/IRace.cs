using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCrazyRace
{
    public interface IRace
    {
        void Iniciar(int distance);
        List<RaceObject> Simulate();
        void PrintDrivers();
        int GetObjectCount();
        RaceObject GetObjectAt(int index);
    }
}
