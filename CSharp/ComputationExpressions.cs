using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CSharp
{
    class ComputationExpressions
    {
        async Task ReadAsync(string file)
        {
            using (var reader = new StreamReader(file))
            {
                var content = await reader.ReadToEndAsync();
                Console.WriteLine("Content: {0}", content);
            }
        }

        public void Run()
        {
            //Task.WaitAll(ReadAsync("Data.csv"));
            //foreach (var i in GetSequence())
            //    Console.WriteLine(i);
            ExecuteOperations();
        }

        public IEnumerable<int> GetSequence()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        public bool OperationOne()
        {
            return true;
        }

        public bool OperationTwo()
        {
            return false;
        }

        public bool OperationThree()
        {
            return true;
        }


        public void ExecuteOperations()
        {
            var resultOne = OperationOne();
            Console.WriteLine(resultOne);
            var resultTwo = OperationTwo();
            Console.WriteLine(resultTwo);
            var resultThree = OperationThree();
            Console.WriteLine(resultThree);
        }
    }
}
