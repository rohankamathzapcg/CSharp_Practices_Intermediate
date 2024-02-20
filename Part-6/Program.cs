namespace part6
{
    public class PeresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine('object was Duplicated.');

        }
    }

    public class Text : PeresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var text=new Text();
            text.Width=100;
            text.Copy();
        }
    }
}