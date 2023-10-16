using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practica11Torneo
{
    public class Tournament:ITournament
    {

        //Se puede crear una instancia de un hijo?
        //Se puede implementar una funcion que genere los combatientes?

        public List<Persona.Humano> lista = new List<Persona.Humano>();

        public List<Persona.Humano> Lista  =>  lista;
        public void InitTournament()
        {
            List<Persona.Humano> roundList = new List<Persona.Humano>();
            Persona.Humano P1 = new Persona.Humano();
            Persona.Humano P2 = new Persona.Humano();
            Persona.Humano P3 = new Persona.Humano {
                Name = "Goku"
            };

            roundList.Add(P1);
            roundList.Add(P2);
            roundList.Add(P3);
            lista = roundList;
            
        }
        public List<string> ExecuteRound()
        {
            List<string> list = new List<string>();
            return list;
        }

        public List<string> Classification()
        {
            List<string> list = new List<string>();
            return list;
        }

    }
}
