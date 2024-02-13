namespace RepasoCurso
{
    public class Equation
    {
        private double _a;
        private double _b;
        private double _c;

        public Equation()
        {

        }

        public Equation(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        private double GetDiscriminante()
        {
            return Math.Sqrt((_b * _b) - (4 * _a * _c));
        }

        public bool FunctionHasTwoSolutions()
        {
            double discriminante = GetDiscriminante();
            return discriminante > 0;
        }

        public bool FunctionHasOneSolution()
        {
            double discriminante = GetDiscriminante();
            return discriminante == 0;
        }

        public (double,double) GetSolution()
        {
            (double sol1, double sol2) solution;
            double discriminante = GetDiscriminante();

            double operation1 = -_b + discriminante;
            solution.sol1 =  operation1 / (2 * _a);

            double operation2 = -_b - discriminante;
            solution.sol2 = operation2 / (2 * _a);

            return solution;
        }
    }
}