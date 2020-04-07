using System;

namespace DemoApp.Topics
{
    public class NullableTypes
    {
        public static void Execute()
        {
            var repo = new Repository();
            
            //2. Handle null ref by design
            //3. Or own the possibility
            var customer = repo.GetCustomerByName(name: "test");
            Console.WriteLine(customer.Name);
        }
    }

    public class Repository
    {
        //1. Be explicit and allow null by design
        public Customer GetCustomerByName(string name)
        {
            if (name == "Juan Perez")
                return new Customer { Name = name };

            return null;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
    }
}