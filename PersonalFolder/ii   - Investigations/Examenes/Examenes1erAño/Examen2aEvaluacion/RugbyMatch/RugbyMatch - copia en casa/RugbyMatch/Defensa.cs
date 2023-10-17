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

        public void MoveDef()
        {
            if (Equipo == EquipoType.EQUIPONORTE)
            {
                PosY -= 1;
            }
            else if (Equipo == EquipoType.EQUIPOSUR)
            {
                PosY += 1;
            }
        }



        // Javi: Función sin hacer


        public override void Ejecutar(Partido P1)
        {

        }
    }
}
