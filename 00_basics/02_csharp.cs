// try to write the code to generate 
// the first 20 numbers in the Fibonacci sequence
// as a hint, the 20th Fibonacci number is 6765

using System;
using System.Collections.Generic;
namespace example
{
    class program
    {
        static void Main()
        {
            //solution1
            //total number you want to show
            var num = 20;
            var fibonacciNumbers = new List<int> {1,1};
            for (int i = 0; i < num-2; i++) // -2 is for the two first number that we know
            {
                var prev1 = fibonacciNumbers[fibonacciNumbers.Count -1];
                var prev2 = fibonacciNumbers[fibonacciNumbers.Count -2];
                fibonacciNumbers.Add( prev1 + prev2 );  
            }
            
            foreach (var number in fibonacciNumbers)
            {
                Console.WriteLine($"{number}");
            }

            Console.WriteLine($"\n \n \n");


            //solution2-while 
            var num2 =20;
            var fibonacciNumbers2= new List<int> {1,1};
            while ( fibonacciNumbers2.Count < num2 )
            {
                var prev1 = fibonacciNumbers2[fibonacciNumbers2.Count -1];
                var prev2 = fibonacciNumbers2[fibonacciNumbers2.Count -2];
                fibonacciNumbers2.Add( prev1 + prev2 );                 
            }

            foreach (var number in fibonacciNumbers2)
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}