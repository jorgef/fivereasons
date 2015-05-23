using System;

namespace CSharp
{
    public class PatternMatching
    {
        public enum DivisionResult
        {
            Success,
            Error
        }

        public void ProcessResult(DivisionResult result)
        {
            switch (result)
            {
                case DivisionResult.Success:
                    Console.WriteLine(":)");
                    break;
                case DivisionResult.Error:
                    Console.WriteLine(":(");
                    break;
            }
        }
    }
}
