namespace part4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1999, 11, 24));
            Console.WriteLine(person.Age);
        }

    }
}