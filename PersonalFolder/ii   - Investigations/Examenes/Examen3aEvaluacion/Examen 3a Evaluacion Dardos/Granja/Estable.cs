namespace Granja
{
    public class Estable
    {
        private string _name = "";
        private int _location;
        private List<Animal> _animalList = new List<Animal>();


        public void AddAnimal(Animal animal)
        {
            if (animal == null)
            {
                //throw new ArgumentNullException();

                // Prefiero hacer una funcion que devuelva un int
                // -1 si existe un parametro incorrecto
                // 0 si esta todo correcto.
                // En este caso me parecía mas limpio que las funciones fueran void
                // y utilizar una Exception.
            }

            _animalList.Add(animal);
        }


        public void RemoveAnimal(Animal animal)
        {
            if (animal == null)
            {
                //throw new ArgumentNullException();
            }

            _animalList.Remove(animal);
        }


        public void RemoveAnimalAt(int index)
        {
            if (index < 0 || index >= _animalList.Count)
            {
                //throw new ArgumentNullException();
            }

            _animalList.RemoveAt(index);
        }


        public int GetListCount()
        {
            return _animalList.Count;
        }


        public List<Animal> AnimalList()
        {
            return _animalList;
            // Este metodo esta pensado para recorrer la lista desde un foreach,
            // por ejemplo desde el program.
        }


        public bool IsAnimal(Animal animal)
        {
            if (animal == null)
            {
                //throw new ArgumentNullException();
            }

            for (int i = 0; i < _animalList.Count; i++)
            {
                return (animal == _animalList[i]);
            }
            return false;
        }


        public bool IsAnimalAt(Animal animal, int index)
        {
            if (animal == null)
            {
                //throw new ArgumentNullException();
            }

            if (index < 0 || index >= _animalList.Count)
            {
                //throw new ArgumentNullException();
            }

            for (int i = 0; i < _animalList.Count; i++)
            {
                return (animal == _animalList[index]);
            }
            return false;
        }


        public Animal GetAnimalAt(int index)
        {
            if (index < 0 || index >= _animalList.Count)
            {
                //throw new ArgumentNullException();
            }

            return _animalList[index];
        }
    }
}
