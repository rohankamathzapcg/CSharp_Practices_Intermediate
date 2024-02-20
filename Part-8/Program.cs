namespace Part8
{
    public class Program
    {
        static void Main(string[] args)
        {
            // StreamReader reader=new StreamReader(new FileStream());
            
            var list=new ArrayList();
            list.Add(1);
            list.Add("Rohan");
            list.Add(new Text());

            var anotherList=new List<Shape>();
            Text text=new Text();
            Shape shape=text;

            text.Width=200;
            shape.Width=100;

            Console.WriteLine(text.width);
        }
    }
}