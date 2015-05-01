using System;

namespace CSharp
{
    public class PatternMatching
    {
        public void ProcessResult(string result)
        {
            switch (result)
            {
                case "Success":
                    Console.WriteLine("Sucess");
                    break;
                case "Error":
                    Console.WriteLine("Error");
                    break;
                default:
                    Console.WriteLine("Invalid: {0}", result);
                    break;
            }
        }

        public void ProcessResult(DivisionResult result)
        {
            switch (result)
            {
                case DivisionResult.Success:
                    Console.WriteLine("Sucess");
                    break;
                case DivisionResult.Error:
                    Console.WriteLine("Error");
                    break;
            }
        }

        public void ProcessResult(DivisionResultBase result)
        {
            var success = result as Success;

            if (success != null)
            {
                Console.WriteLine("Sucess: {0} {1}", success.Quotient, success.Remainder);
                return;
            }

            var error = result as Error;

            if (error != null)
            {
                Console.WriteLine("Error: {0}", error.Message);
            }
        }
    }

}
