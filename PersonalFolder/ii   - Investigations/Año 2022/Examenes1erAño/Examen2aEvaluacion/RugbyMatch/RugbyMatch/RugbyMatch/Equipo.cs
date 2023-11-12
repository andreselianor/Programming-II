using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public enum EquipoType
    {
        EQUIPOA,
        EQUIPOB,
        DEMENTOR
    }
    public class Equipo
    {
        private EquipoType _nombreEquipo;

        public EquipoType NombreEquipo
        {
            get { return _nombreEquipo; }            
        }
    }
}
