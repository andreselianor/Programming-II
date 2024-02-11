namespace FarmRevisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new BraveHorse();
            Animal a2 = new DomatedHorse();
            Animal a3 = new Cow();
            Animal a4 = new Chicken();
            Animal a5 = new Duck();
            Stable s1 = new Stable("perquera", "direccion1");

            s1.AddAnimal(a1);
            s1.AddAnimal(a2);
            s1.AddAnimal(a3);
            s1.AddAnimal(a4);
            s1.AddAnimal(a5);

            AnimalType a = a3.GetAnimalType();
            AnimalType b = a4.GetAnimalType();
            AnimalType c = a5.GetAnimalType();

            a1.Weigth = 100.0;
            double result1 = a1.GetQualification();
        }
    }
}