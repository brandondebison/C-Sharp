using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2400_Activity_Chp6
{
    class Program
    {
        static void Main(string[] args)
        {




                System.Console.WriteLine("-------------------------------------- First Question (1) --------------------------------------------------------\n");

            System.Console.WriteLine("Enter a number to count to\n");

            int inputQOne = int.Parse(Console.ReadLine());
            int counter = 0;
            if (inputQOne > 0) { 
                for (int i = 0; i <= inputQOne; i++)
                {
                    System.Console.WriteLine("Starting at " + i);

                }
            } else {
                System.Console.WriteLine("Number must be greater than 0 ");

            }



            System.Console.WriteLine("\n");




            System.Console.WriteLine("-------------------------------------- Second Question (2) --------------------------------------------------------\n");
            

           System.Console.WriteLine("Please enter a number\n");

            int inputQTwo = int.Parse(Console.ReadLine());

            for (int i = 1; i < inputQTwo; i++)
            {
                if (i % 3 != 0 && i %7 != 0) { Console.WriteLine(i); }
            }


            System.Console.WriteLine("\n");



            System.Console.WriteLine("-------------------------------------- Third Question (10) --------------------------------------------------------\n");


            System.Console.WriteLine("Input 5 numbers. We will tell you what is the largest and smallest\n");
            int inputNumber1 = int.Parse(Console.ReadLine());
            int inputNumber2 = int.Parse(Console.ReadLine());
            int inputNumber3 = int.Parse(Console.ReadLine());
            int inputNumber4 = int.Parse(Console.ReadLine());
            int inputNumber5 = int.Parse(Console.ReadLine());

            int smallest = 0;
            int largest = 0;



            if (inputNumber1 > inputNumber2 )
            {
                largest = inputNumber1;
                smallest = inputNumber2;
            } else
            {
                largest = inputNumber2;
                smallest = inputNumber1;
            }

            if (largest < inputNumber3 )
            {
                largest = inputNumber3;
            } else if (smallest > inputNumber3)
            {
                smallest = inputNumber3;
            }

            if (largest < inputNumber4)
            {
                largest = inputNumber4;
            }
            else if (smallest > inputNumber4)
            {
                smallest = inputNumber4;
            }

            if (largest < inputNumber5)
            {
                largest = inputNumber5;
            }
            else if (smallest > inputNumber5)
            {
                smallest = inputNumber5;
            }

            System.Console.WriteLine("Largest number is: " + largest + " Smallest number is: " +smallest);




        }
    }
}
