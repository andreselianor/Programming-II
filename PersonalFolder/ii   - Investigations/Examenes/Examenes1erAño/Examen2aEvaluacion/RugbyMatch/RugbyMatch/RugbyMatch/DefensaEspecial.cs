using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class DefensaEspecial : Defensa
    {
        public DefensaEspecial(int x, int y, string nombre, EquipoType equipo) : base(x, y, nombre, equipo)
        {

        }

        public override void Ejecutar(Pelota P)
        {          

            //EL DEFENSA ESPECIAL HACE LO MISMO QUE UN DEFENSA NORMAL

            base.Ejecutar(P);

            //Y ADEMAS
            //METODO DESACTIVAR UN CONTRINCANTE


        }

    }
}
