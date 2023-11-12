using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class Partido
    {
        private List<Personaje> _listaPersonajes = new List<Personaje>();
        private Pelota _pelota;
        private int _marcadorA;
        private int _marcadorB;
        private int _campoJuegoX;
        private int _campoJuegoY;
        

        public Partido(int x, int y)
        {
            _campoJuegoX = x;
            _campoJuegoY = y;
        }

        public List<Personaje> ListaPersonajes
        {
            get { return _listaPersonajes; }
        }

        public Pelota Pelota
        {
            get { return _pelota; }
        }


        public void Inicio()
        {
            Pelota pelota = new Pelota(5, 10);


            // EQUIPO A - ARRIBA
            Personaje P1A = new Delantero(4, 2, "DEL1",EquipoType.EQUIPOA);
            Personaje P2A = new Delantero(5, 2, "DEL2", EquipoType.EQUIPOA);
            Personaje P3A = new Delantero(6, 2, "DEL3", EquipoType.EQUIPOA);
            Personaje P4A = new Delantero(7, 2, "DEL4", EquipoType.EQUIPOA);

            Personaje P5A = new Defensa(4, 1, "DEF1", EquipoType.EQUIPOA);
            Personaje P6A = new Defensa(5, 1, "DEF2", EquipoType.EQUIPOA);
            Personaje P7A = new Defensa(6, 1, "DEF3", EquipoType.EQUIPOA);
            Personaje P8A = new Defensa(7, 1, "DEF4", EquipoType.EQUIPOA);

            Personaje P9A = new DefensaEspecial(3, 1, "DEF5", EquipoType.EQUIPOA);
            Personaje P10A = new DefensaEspecial(8, 1, "DEF6", EquipoType.EQUIPOA);

            // EQUIPO A - ARRIBA
            Personaje P1B = new Delantero(4, 2, "DEL1", EquipoType.EQUIPOB);
            Personaje P2B = new Delantero(5, 2, "DEL2", EquipoType.EQUIPOB);
            Personaje P3B = new Delantero(6, 2, "DEL3", EquipoType.EQUIPOB);
            Personaje P4B = new Delantero(7, 2, "DEL4", EquipoType.EQUIPOB);

            Personaje P5B = new Defensa(4, 1, "DEF1", EquipoType.EQUIPOB);
            Personaje P6B = new Defensa(5, 1, "DEF2", EquipoType.EQUIPOB);
            Personaje P7B = new Defensa(6, 1, "DEF3", EquipoType.EQUIPOB);
            Personaje P8B = new Defensa(7, 1, "DEF4", EquipoType.EQUIPOB);

            Personaje P9B = new DefensaEspecial(3, 1, "DEF5", EquipoType.EQUIPOB);
            Personaje P10B = new DefensaEspecial(8, 1, "DEF6", EquipoType.EQUIPOB);


            // DEMENTORES
            Personaje PD1 = new Dementor(5,10, "DEM1", EquipoType.DEMENTOR);
            Personaje PD2 = new Dementor(6,10, "DEM2", EquipoType.DEMENTOR);
            Personaje PD3 = new Dementor(5,11, "DEM3", EquipoType.DEMENTOR);
            Personaje PD4 = new Dementor(6,11, "DEM4", EquipoType.DEMENTOR);


            _listaPersonajes.Add(P1A);
            _listaPersonajes.Add(P1B);

            // SE REPITE CON TODOS LOS PERSONAJES

        }       

        public void Goal()
        {
            _marcadorA += 1;
            _marcadorB += 0;
            Inicio();
        }


        public void Play()
        {
            int turnos = 0;
            while(turnos < 1000)
            {
                for (int i = 0; i <_listaPersonajes.Count; i++)
                {
                    _listaPersonajes[i].Ejecutar(Pelota);
                }

                turnos++;
            }
        }
    }
}
