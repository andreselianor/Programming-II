using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class GenerarPersonajes
    {
        public static List<Personaje> GenerarList()
        {
            List<Personaje> lista = new List<Personaje>();
            lista.Clear();

            // EQUIPO NORTE - ARRIBA
            Personaje P1A = new Delantero(4, 2, "DEL1A", EquipoType.EQUIPONORTE);
            lista.Add(P1A);

            Personaje P2A = new Delantero(5, 2, "DEL2A", EquipoType.EQUIPONORTE);
            lista.Add(P2A);
            Personaje P3A = new Delantero(6, 2, "DEL3A", EquipoType.EQUIPONORTE);
            lista.Add(P3A);
            Personaje P4A = new Delantero(7, 2, "DEL4A", EquipoType.EQUIPONORTE);
            lista.Add(P4A);

            Personaje P5A = new Defensa(4, 1, "DEF1A", EquipoType.EQUIPONORTE);
            lista.Add(P5A);
            Personaje P6A = new Defensa(5, 1, "DEF2A", EquipoType.EQUIPONORTE);
            lista.Add(P6A);
            Personaje P7A = new Defensa(6, 1, "DEF3A", EquipoType.EQUIPONORTE);
            lista.Add(P7A);
            Personaje P8A = new Defensa(7, 1, "DEF4A", EquipoType.EQUIPONORTE);
            lista.Add(P8A);

            Personaje P9A = new DefensaEspecial(3, 1, "DEF5A", EquipoType.EQUIPONORTE);
            lista.Add(P9A);
            Personaje P10A = new DefensaEspecial(8, 1, "DEF6A", EquipoType.EQUIPONORTE);
            lista.Add(P10A);

            // EQUIPO SUR - ABAJO
            Personaje P1B = new Delantero(4, 19, "DEL1B", EquipoType.EQUIPOSUR);
            lista.Add(P1B);
            Personaje P2B = new Delantero(5, 19, "DEL2B", EquipoType.EQUIPOSUR);
            lista.Add(P2B);
            Personaje P3B = new Delantero(6, 19, "DEL3B", EquipoType.EQUIPOSUR);
            lista.Add(P3B);
            Personaje P4B = new Delantero(7, 19, "DEL4B", EquipoType.EQUIPOSUR);
            lista.Add(P4B);

            Personaje P5B = new Defensa(4, 20, "DEF1B", EquipoType.EQUIPOSUR);
            lista.Add(P5B);
            Personaje P6B = new Defensa(5, 20, "DEF2B", EquipoType.EQUIPOSUR);
            lista.Add(P6B);
            Personaje P7B = new Defensa(6, 20, "DEF3B", EquipoType.EQUIPOSUR);
            lista.Add(P7B);
            Personaje P8B = new Defensa(7, 20, "DEF4B", EquipoType.EQUIPOSUR);
            lista.Add(P8B);
            Personaje P9B = new DefensaEspecial(3, 20, "DEF5B", EquipoType.EQUIPOSUR);
            lista.Add(P9B);
            Personaje P10B = new DefensaEspecial(8, 20, "DEF6B", EquipoType.EQUIPOSUR);
            lista.Add(P10A);


            // DEMENTORES
            Personaje P1D = new Dementor(5, 10, "DEM1", EquipoType.DEMENTOR);
            lista.Add(P1D);
            Personaje P2D = new Dementor(6, 10, "DEM2", EquipoType.DEMENTOR);
            lista.Add(P2D);
            Personaje P3D = new Dementor(5, 11, "DEM3", EquipoType.DEMENTOR);
            lista.Add(P3D);
            Personaje P4D = new Dementor(6, 11, "DEM4", EquipoType.DEMENTOR);
            lista.Add(P4D);

            return lista;
        }
    }
}
