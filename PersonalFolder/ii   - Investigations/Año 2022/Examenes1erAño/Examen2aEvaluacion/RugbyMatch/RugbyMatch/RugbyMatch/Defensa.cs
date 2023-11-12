using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class Defensa : Personaje
    {
        public Defensa(int x, int y, string nombre, EquipoType equipo) : base(x, y, nombre, equipo)
        {

        }

        public override void Ejecutar(Pelota P)
        {

            //EL DEFENSA TIENE VARIOS METODOS:

            //METODO PASAR A UN COMPAÑERO

            if (_equipo == EquipoType.EQUIPOA
                && _posesion == true)
            {
                
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
