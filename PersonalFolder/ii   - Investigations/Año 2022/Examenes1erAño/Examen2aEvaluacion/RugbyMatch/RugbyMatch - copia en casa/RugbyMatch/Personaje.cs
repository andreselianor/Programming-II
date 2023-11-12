using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public abstract class Personaje
    {
        private int _posX;
        private int _posY;
        private string _nombre;
        private EquipoType _equipo;
        private bool _posesion;

        public int PosX
        {
            get { return _posX; }
            set { _posX = value; }
        }

        public int PosY
        {
            get { return _posY; }
            set { _posY = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public EquipoType Equipo
        {
            get { return _equipo; }
        }

        public bool Posesion
        {
            get { return _posesion; }
            set { _posesion = value; }
        }

        public Personaje(int x, int y, string nombre, EquipoType equipo)
        {
            _posX = x;
            _posY = y;
            _nombre = nombre;
            _equipo = equipo;
        }

        // FUNCIONES DE CLASE

        public abstract void Ejecutar(Partido P1);
    }
}
