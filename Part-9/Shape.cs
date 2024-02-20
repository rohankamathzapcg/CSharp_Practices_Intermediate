namespace Part9
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            //
        }
    }

    public class Cricle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");

        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Daw a Rectangle");
            
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
            
        }
    }
}