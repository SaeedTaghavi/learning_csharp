// Hello World! program
using System;
using System.Collections.Generic;
namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            int max=int.MaxValue;
            int min=int.MinValue;
            System.Console.WriteLine($"{max}");
            System.Console.WriteLine($"{min}");
            int what = max +1;
            Console.WriteLine($"int.MaxValue +1 = {what}");

            double a =1.0;
            double b = 3.0;
            System.Console.WriteLine(a/b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            System.Console.WriteLine(c/d);

            
            System.Console.WriteLine("\n \n \n");

            //using if statement
            a = 5;
            b = 6;
            bool condition1 = a+b>10;
            if (condition1)
            {
                System.Console.WriteLine("the answer is grater that 10");
            }
            else
            {
                System.Console.WriteLine("the answer is not grater that 10");
            }

            
            System.Console.WriteLine("\n \n \n");

            // using while loop
            int counter = 0 ;
            while (counter <10)
            {
                Console.WriteLine($"counter is {counter}");
                counter ++;
            }


            System.Console.WriteLine("\n \n \n");

            //using do while loop
            counter = 0; 
            do 
            {
                Console.WriteLine($"counter is {counter}");
                counter ++;
            } while (counter<10);


            System.Console.WriteLine("\n \n \n");

            //using for loop
            for (int index=0; index<10; index++)
            {
                Console.WriteLine($"index is {index}")   ;
            }


            System.Console.WriteLine("\n \n \n");

            //loops and if

            // ex01
            // see if you can write a code to find 
            // the sum of all integers 1 through 20 
            // thatare divisible by 3.

            // int x=4;
            // int rem=x%3; % gives you the reminder of a division
            int sum = 0 ;
            for (int i = 0; i < 20; i++)
            {
                if (i%3==0)
                {
                    sum = sum + i;
                }
            }
            System.Console.WriteLine($"for: the sum is {sum}");

            sum =0;
            int number = 0;
            while (number<20)
            {
                if (number%3==0)
                {
                    sum = sum+number;
                }
                number++;
            }
            System.Console.WriteLine($"while: the sum is {sum}");

            
            System.Console.WriteLine("\n \n \n");

            // using Lists
            var names = new List<string> {"<name>","Alice", "Bob"};
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }


            Console.WriteLine("\n \n \n");


            names.Add("Taghi");
            names.Add("Naghi");
            names.Remove("Bob");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }

            var ii=0;
            Console.WriteLine($"Hello {ii}!");


            // sort, search and index lists
            var index1 =names.IndexOf("Taghi");
            if (index1==-1)
            {
                Console.WriteLine($"the item is not in list!");   
            }
            else
            {
                Console.WriteLine($"found Taghi at {index1}");
            }
            names.Add("Bob");

            Console.WriteLine("\n \n \n");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }


            

        }
    }
}
