using System;

namespace CSharp
{
    class Customer
    {
        private readonly string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }

    class CustomerRecord
    {
        private readonly string name;

        public CustomerRecord(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        protected bool Equals(CustomerRecord other)
        {
            return string.Equals(name, other.name);
        }

        public override int GetHashCode()
        {
            return (name != null ? name.GetHashCode() : 0);
        }
    }

    class TuplesSample
    {
        public void Execute()
        {
            Tuple<string, int> myTuple = GetNameAndAge(3);
            string name = myTuple.Item1;
            int age = myTuple.Item2;
        }

        private Tuple<string, int> GetNameAndAge(int id)
        {
            return Tuple.Create("John", 42);
        }
    }

    public class OptionsSample
    {
        int GetCustomerAgeById(int id)
        {
            return 42;
        }

        int? GetNullableCustomerAgeById(int id)
        {
            return id < 0 ? (int?)null : 42;
        }

        Customer GetCustomerById(int id)
        {
            return id < 0 ? null : new Customer("John");
        }
    }

    public class AnonymousTypes
    {
        dynamic GetProduct()
        {
            return new { Name = "Product1" };
        }

        void PrintName()
        {
            var product = GetProduct();
            Console.WriteLine("Name: {0}", product.Name);
        }
    }
}