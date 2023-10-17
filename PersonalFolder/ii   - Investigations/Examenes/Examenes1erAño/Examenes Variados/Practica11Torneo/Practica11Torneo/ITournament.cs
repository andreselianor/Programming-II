using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11Torneo
{
    public interface ITournament
    {
        //TODO Instanciar una clase hijo, notacion de punto?
        //Estructura del programa
        //Interfaz -> Clase General donde se invocan metodos -> Clases de objetos con atributos y metodos

        void InitTournament();
        List<string> ExecuteRound();
        List<string> Classification();

    }
}
