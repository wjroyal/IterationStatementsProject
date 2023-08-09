using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //Declare and Initialize Variable
            int num;
            num = 0;



            //Do-While Loop adding consecutively to variable
            do
            {
                num++;
                numbers.Add(num);
               
            } 
            while (num < 100);


            while (num < 200)

            {
                
                num++;
                numbers.Add(num); 

            }

            //Increase
            Console.WriteLine("Increase:");
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");

            }
            //Decrease
            Console.WriteLine("");
            Console.WriteLine("Decrease:");
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {

                Console.WriteLine($"{numbers[i]}"); 
            }
        }
    }
}
