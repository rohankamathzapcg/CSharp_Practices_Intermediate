namespace Part2
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> orders;
        public Customer()
        {
            orders=new Lit<Order>();
        }
        public Customer(int id)
        {
            this.Id=id;
        }
        public Customer(int id,string name):this(id)
        {
            this.Name=name;
        }

        public void Promote()
        {
            orders=new List<Order>();
        }
    }
}