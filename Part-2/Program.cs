namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method Overloading
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0},{1})", point.x, point.y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0},{1})", point.x, point.y);

            //Using Params Modifier
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));

            //Out Modifier

            //using TryParse
            int number;
            int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }

            //using parse
            try
            {
                var num=int.Parse("abc");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Conversion Failed!!");
            }

        }
    }
}