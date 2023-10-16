using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public abstract class Personaje
    {
        protected int _posX;
        protected int _posY;
        protected string _nombre;
        protected EquipoType _equipo;
        protected bool _posesion;

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

        public Personaje(int x, int y, string nombre, EquipoType equipo)
        {
            _posX = x;
            _posY = y;
            _nombre = nombre;
            _equipo = equipo;
        }

        public virtual void HasBall(Pelota P1)
        {
            if (PosX == P1.PelotaX &&
                PosY == P1.PelotaY)
            {
                _posesion = true;
            }
            else
            {
                _posesion = false;
            }          
        }

        public bool HasBall()
        {
            return _posesion == true;
        }
        // ENTIENDO QUE LAS DOS FUNCIONES SON REDUNDANTES, PERO AUN NO SE CON CUAL ME VOY A QUEDAR

        public abstract void Ejecutar(Pelota P1);
    }
}
