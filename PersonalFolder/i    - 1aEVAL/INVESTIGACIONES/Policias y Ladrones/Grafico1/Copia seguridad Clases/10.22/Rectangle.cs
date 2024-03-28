namespace Grafico1
{
    public class Rectangle
    {
        private double x;
        private double y;

        private double width;
        private double height;


        // CONSTRUCTORES
        public Rectangle()
        {
            width = 1;
            height = 1;
        }
        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;
            width = 1;
            height = 1;
        }


        // GETTERS & SETTERS
        public double X
        {
            get{ return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        // METODOS
        public bool IntersectionRectangle(Rectangle r)
        {
            if (this.x > r.x && this.x < r.x + r.width) // TODO: 4 CONDICIONALES?
            {
                return true;
            }
            return false;                
        }

        public void Destroy()
        {
            double velocity = 0;
            while(width > 0)
            {
                
                
            }                        
        }
    }
}
