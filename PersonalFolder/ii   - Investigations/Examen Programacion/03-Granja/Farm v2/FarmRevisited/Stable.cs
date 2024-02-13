namespace FarmRevisited
{
    public class Stable
    {
        private string _name = "";
        private string _address = "";
        private List<Animal> _listAnimals = new List<Animal>();

        public Stable()
        {

        }
        public Stable(string name, string address)
        {
            _name = name;
            _address = address;
        }

        public void AddAnimal(Animal animal)
        {
            if (animal == null)
                return;
            _listAnimals.Add(animal);
        }

        public int GetIndexOf(Animal animal)
        {
            if (animal == null)
                return -1;

            List<Animal> list = _listAnimals;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == animal)
                    return i;
            }
            return -1;
        }

        public int GetAnimalCount()
        {
            return _listAnimals.Count;
        }

        public void RemoveAt(int index)
        {
            _listAnimals.RemoveAt(index);
        }

        public bool ContainsAnimal(Animal animal)
        {
            if (animal == null)
                return false;
            return GetIndexOf(animal) >= 0;
        }

        public void Clear()
        {
            _listAnimals.Clear();
        }

        public List<Animal> Clone(List<Animal> animalList)
        {
            if (animalList == null)
                return null;

            List<Animal> listResult = new List<Animal>();

            for(int i = 0; i < animalList.Count; i++)
            {
                listResult.Add(animalList[i]);
            }

            return listResult;
        }

        public bool IsEmpty => _listAnimals.Count > 0;

        public override string ToString()
        {
            string result = "";
            int count = 0;
            foreach (Animal animal in _listAnimals)
            {
                result += $"El animal que ocupa la posicion numero {count} es el animal {animal.ID}";
                count++;
            }
            return result;
        }

        public void DisplayContent()
        {
            string result = "";
            foreach(Animal animal in _listAnimals)
            {
                result = animal.ID;
                Console.WriteLine(result);
            }
        }

        /*
         * FUNCION FILTER
         * FUNCION VISIT
         * 
         */
    }
}
