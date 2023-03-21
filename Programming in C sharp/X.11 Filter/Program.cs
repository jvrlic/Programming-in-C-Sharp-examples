namespace X._11_Filter
{
    class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Joe", City = "Paris"},
                new Customer { Name = "Devon", City = "London"},
                new Customer { Name = "Mate", City = "Zagreb"},
                new Customer { Name = "John", City = "Los Angeles"},
                new Customer { Name = "Julio", City = "London"}
            };

            var queryLondonCustomers = from cust in customers
                                       where cust.City == "London"
                                       //where cust.City=="London" && cust.Name == "Devon"
                                       //where cust.City == "London" || cust.City == "Paris"
                                       select cust;

            foreach (var c in queryLondonCustomers)
            {
                Console.WriteLine(c.Name);
            }

        }
    }
}