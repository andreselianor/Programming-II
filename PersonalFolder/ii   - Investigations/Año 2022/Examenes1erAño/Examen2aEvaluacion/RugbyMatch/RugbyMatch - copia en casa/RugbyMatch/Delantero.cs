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

        public override void Ejecutar(Partido P1)
        {

            // Funcion Mover Pelota

            if (Equipo == EquipoType.EQUIPONORTE)
            {
                if (Posesion == true)
                {
                    PosY += 1;
                    P1.Pelota.PelotaY += 1;
                }
                else
                {
                    PosY -= 1;
                }
            }

            if (Equipo == EquipoType.EQUIPOSUR)
            {
                if (Posesion == true)
                {
                    PosY -= 1;
                    P1.Pelota.PelotaY += PosY;
                }
                else
                {
                    PosY += 1;
                }
            }

            // Funcion Marcar Puntos

            if (Equipo == EquipoType.EQUIPONORTE)
            {
                if (Posesion == true && PosY > 19)
                {
                    P1.Score(10, EquipoType.EQUIPONORTE);
                }
            }
            else if (Equipo == EquipoType.EQUIPOSUR)
            {
                if (Posesion == true && PosY < 1)
                {
                    P1.Score(10, EquipoType.EQUIPOSUR);
                }
            }
        }
    }
}
