namespace HerenciaI
{
    public class Graveyard
    {
        private List<Person> _listPerson = new List<Person>();

        public int PersonCount
        {
            get
            {
                return _listPerson.Count;
            }
        }

        public int GetPersonCount()
        {
            return _listPerson.Count;
        }

        public int PersonCountAlt
        {
            get
            {
                return GetPersonCount();
            }
        }



        // Estas son las 4 funciones Obligatorias para manejar cualquier lista.
        public int GetListCount()
        {
            return _listPerson.Count;
        }

        public Person GetPersonAt(int index)
        {
            return _listPerson[index];
        }

        public void AddPerson(Person person)
        {
            _listPerson.Add(person);
        }

        public void RemovePersonAt(int index)
        {
            _listPerson.RemoveAt(index);
        }
    }
}
