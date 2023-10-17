using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class Delantero : Personaje
    {
        public Delantero(int x, int y, string nombre, EquipoType equipo) : base(x, y, nombre, equipo)
        {

        }

        public override void Ejecutar(Pelota P1)
        {
            
            if(_equipo == EquipoType.EQUIPOA)
            {
                if(_posesion == true)
                {
                    PosY += 1;
                }
                else
                {
                    PosY -= 1;
                }
            }

            if (_equipo == EquipoType.EQUIPOB)
            {
                if (_posesion == true)
                {
                    PosY -= 1;
                }
                else
                {
                    PosY += 1;
                }
            }
        }
    }
}
