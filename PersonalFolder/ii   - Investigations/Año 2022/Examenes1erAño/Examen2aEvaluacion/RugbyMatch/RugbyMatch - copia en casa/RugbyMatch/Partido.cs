using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class Partido
    {
        private List<Personaje> _listaPersonaje = new List<Personaje>();
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

        // PROPERTIES CLASE PARTIDO

        public int MarcadorA
        {
            get { return _marcadorA; }
            set { _marcadorA = value; }
        }

        public int MarcadorB
        {
            get { return _marcadorB; }
            set { _marcadorB = value; }
        }

        // Javi: Esta property no se debe hacer
        // Corregido .-
        public List<Personaje> ListaPersonajes
        {
            get { return _listaPersonaje; }
        }

        public Pelota Pelota
        {
            get { return _pelota; }
            set { _pelota = value; }
        }


        // FUNCIONES DE CLASE PARTIDO

        public void Inicio()
        {
            _pelota = new Pelota(4, 2);
            _listaPersonaje = GenerarPersonajes.GenerarList();
        }

        public void Score(int number, EquipoType equipo)
        {
            if (equipo == EquipoType.EQUIPONORTE)
            {                
                _marcadorA += number;
            }
            else if (equipo == EquipoType.EQUIPOSUR)
            {
                _marcadorB += number;
            }

            Inicio();
        }

        public void Play(Partido P1)
        {
            int turnos = 0;
            while (turnos < 110)
            {
                for (int i = 0; i < _listaPersonaje.Count; i++)
                {
                    P1.Pelota.HasPossesion(P1);
                    _listaPersonaje[i].Ejecutar(P1);                    
                }
                turnos++;
            }
        }

        public EquipoType Ganador(Partido P1)
        {
            if(P1.MarcadorA > P1.MarcadorB)
            {
                return EquipoType.EQUIPONORTE;
            }
            else
            {
                return EquipoType.EQUIPOSUR;
            }
        }
    }
}
