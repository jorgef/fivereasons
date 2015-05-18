using System;

namespace CSharp
{
    public class MyType
    {
        private readonly int fieldOne;
        private readonly string fieldTwo;

        public MyType(int fieldOne, string fieldTwo)
        {
            this.fieldOne = fieldOne;
            this.fieldTwo = fieldTwo;
        }

        public int PropertyOne
        {
            get { return fieldOne; }
        }

        public string PropertyTwo
        {
            get { return fieldTwo; }
        }











        public void Tuples()
        {
            var myTuple = Tuple.Create(1, "value");
            var valueOne = myTuple.Item1;
            var valueTwo = myTuple.Item2;

            int value;
            var success = Int32.TryParse("42", out value);
        }
    }

    public class Nulls
    {
        public Customer GetCustomerById(int id)
        {
            return id == 0 ? null : new Customer();
        }

        public int? GetNullableCustomerAgeById(int id)
        {
            return 42;
        }

        public int GetCustomerAgeById(int id)
        {
            return 42;
        }
    }

    public class Customer
    {
        public int Age { get; set; }
    }

    public enum DivisionResult
    {
        Success,
        Error
    }

    public abstract class DivisionResultBase
    {
    }

    public class Success : DivisionResultBase
    {
        public int Quotient { get; set; }
        public int Remainder { get; set; }
    }

    public class Error : DivisionResultBase
    {
        public string Message { get; set; }
    }

    public class MyDisposableObject : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose executed");
        }
    }

    public interface IProduct
    {
        string Name { get; }
    }

    public class AnonymousTypes
    {
        public object GetProduct()
        {
            return new { Name = "Product1" };
        }

        public void PrintName(IProduct product)
        {
            Console.WriteLine("Name: {0}", product.Name);
        }
    }
}


