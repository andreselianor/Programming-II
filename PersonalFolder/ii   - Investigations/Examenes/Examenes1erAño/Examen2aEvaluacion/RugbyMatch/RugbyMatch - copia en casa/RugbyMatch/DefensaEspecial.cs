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

        public override void Ejecutar(Partido P1)
        {

        }

    }
}
