namespace part7
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        // public Vehicle()
        // {
        //     Console.WriteLine("Vehicle is being initialized");
        // }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized");

        }
    }

    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized.");
        }
    }

    public class program
    {
        static void Main(string[] args)
        {
            var car = new Car("XYZ!1223");
        }
    }
}