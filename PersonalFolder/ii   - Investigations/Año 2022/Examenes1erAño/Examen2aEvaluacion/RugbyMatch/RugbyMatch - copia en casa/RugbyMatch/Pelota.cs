using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class Pelota
    {
        private int _pelotaX;
        private int _pelotaY;

        public int PelotaX
        {
            get { return _pelotaX; }
            set { _pelotaX = value; }
        }
        public int PelotaY
        {
            get { return _pelotaY; }
            set { _pelotaY = value; }
        }

        public Pelota(int x, int y)
        {
            _pelotaX = x;
            _pelotaY = y;        
        }

        public void HasPossesion(Partido P1)
        {
            for (int i = 0; i < P1.ListaPersonajes.Count; i++)
            {
                if (P1.ListaPersonajes[i].PosX == P1.Pelota.PelotaX &&
                    P1.ListaPersonajes[i].PosY == P1.Pelota.PelotaY)
                {
                    P1.ListaPersonajes[i].Posesion = true;
                    PelotaX = P1.ListaPersonajes[i].PosX;
                    PelotaY = P1.ListaPersonajes[i].PosY;
                }
                else
                {
                    P1.ListaPersonajes[i].Posesion = false;
                }
            }
        }
    }
}
