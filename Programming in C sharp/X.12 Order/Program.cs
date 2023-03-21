namespace X._12_Order
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
                new Customer { Name = "Julio", City = "London"},
                new Customer { Name = "Angelo", City = "London"}
            };

            var queryLondonCustomers3 =
                     from cust in customers
                     where cust.City == "London"
                     orderby cust.Name ascending
                     select cust;

            foreach (var c in queryLondonCustomers3)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}