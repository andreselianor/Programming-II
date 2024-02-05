namespace CrazyCarsII
{
    public class GlamourCar : Car
    {
        private string _name = "";
        
        public override void Execute()
        {
            Position += 40;
        }

        public override void Report()
        {
            Console.WriteLine("Nani de GlamourCar:");
            Console.WriteLine("Avanzo tranquilamente por mi carril a 40 km/h");
            Console.WriteLine("");
        }
    }
}
