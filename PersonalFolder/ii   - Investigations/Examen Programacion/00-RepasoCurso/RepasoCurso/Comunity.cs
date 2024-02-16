namespace RepasoCurso
{
    public class Comunity
    {
        private class Person
        {
            private int _age;
            private string _name;
        }

        private class Property
        {
            private int _floor;
            private char _letter = ' ';
            private List<Person> _listPersons = new List<Person>();

            public int Floor
            {
                get { return _floor; }
                set { _floor = value; }
            }

            public char Letter
            {
                get { return _letter; }
                set { _letter = value; }
            }

            public int PersonsCount => _listPersons.Count;

            public List<Person> CloneList()
            {
                List<Person> cloneList = new List<Person>();
                for(int i = 0; i < _listPersons.Count; i++)
                {
                    cloneList[i] = _listPersons[i];
                }
                return cloneList;
            }
            public Property Clone()
            {
                Property clone = new Property();
                clone.Floor = _floor;
                clone.Letter = _letter;
                clone._listPersons = _listPersons;

                return clone;
            }
        }

        private class Community
        {
            private List<Property> _listProperties = new List<Property>();

            public int PropertiesCount => _listProperties.Count;
            public int PersonsCount 
            {
                get
                {
                    int result = 0;
                    for (int i = 0; i < _listProperties.Count; i++)
                    {
                        result += _listProperties[i].PersonsCount;
                    }
                    return result;
                }
            }       // TODO predicate ALL

            public void AddProperty(Property property)
            {
                if (property == null)
                    return;

                _listProperties.Add(property);
            }

            public void RemovePropertyAt(int index)
            {

            }

            public void Clear()
            {
                _listProperties = new List<Property>();
            }

            public List<Property> Clone()
            {
                List<Property> clone = new List<Property>();
                
                for(int i = 0; i < _listProperties.Count; i++)
                {
                    clone[i] = _listProperties[i].Clone();
                }
                return clone;
            }
        }
    }
}
