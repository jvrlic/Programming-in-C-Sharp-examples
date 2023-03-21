namespace X._13_Group
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


            // queryCustomersByCity is an IEnumerable<IGrouping<string, Customer>> 
            var queryCustomersByCity =
                from cust in customers
                group cust by cust.City;
            /*
            var queryCustomersByCity =
                from cust in customers
                group cust by cust.City into custGroup
                where custGroup.Count() > 2
                orderby custGroup.Key
                select custGroup;
             * */


            // customerGroup is an IGrouping<string, Customer> 
            foreach (var customerGroup in queryCustomersByCity)
            {
                Console.WriteLine(customerGroup.Key);
                foreach (Customer customer in customerGroup)
                {
                    Console.WriteLine("    {0}", customer.Name);
                }
            }
        }
    }
}