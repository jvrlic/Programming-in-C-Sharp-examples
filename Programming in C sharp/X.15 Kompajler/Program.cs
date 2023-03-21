namespace X._15_Kompajler
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


            var customerQuery2 =
                from cust in customers
                where cust.City == "London"
                select cust;

            foreach (var customer in customerQuery2)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}