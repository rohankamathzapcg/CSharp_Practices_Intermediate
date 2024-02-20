namespace Part2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer=new Customer(1);
            customer.orders.Add(new Order());
            customer.orders.Add(new Order());

            customer.Promote();
            
            Console.WriteLine(customer.Orders.Count);
            
        }
    }
}