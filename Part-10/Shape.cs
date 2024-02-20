namespace Part10
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {  
            Console.WriteLine("Select the shape");    
        }
    }
}