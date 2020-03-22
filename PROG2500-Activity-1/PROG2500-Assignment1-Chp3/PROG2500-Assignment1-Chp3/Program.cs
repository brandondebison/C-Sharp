using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_Assignment1_Chp3
{
    class Program
    {
        static void Main(string[] args)
        {


            System.Console.WriteLine("-------------------------------------- First Question (2) --------------------------------------------------------\n");
            System.Console.WriteLine("Enter a number to know if it it is even or odd");

            int inputOne = int.Parse(System.Console.ReadLine());
            
            int answer = 0;

            answer = inputOne % 2; 

            if (answer == 0)
            {
                System.Console.WriteLine(inputOne +" is even");
            } else
            {
                System.Console.WriteLine(inputOne + " is odd");
            }

            System.Console.WriteLine("Try another number");

            int inputTwo = int.Parse(System.Console.ReadLine());

            answer = inputTwo % 2;

            if (answer == 0)
            {
                System.Console.WriteLine(inputTwo + " is even\n\n");
            }
            else
            {
                System.Console.WriteLine(inputTwo + " is odd\n\n");
            }

            

            System.Console.WriteLine("-------------------------------------- Second Question (6) --------------------------------------------------------\n" );

            System.Console.WriteLine("Lets calculate the perimeter and the area of a rectangle \n");
            System.Console.WriteLine("Enter in the lenght of rectangle\n");


            int lenght = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Enter in the height of the rectanlge\n");

            int height = int.Parse(System.Console.ReadLine());


            System.Console.WriteLine("The perimeter of the rectangle is: " + ((lenght + height) * 2) + " and the area of the rectanglt is: " + (lenght * height) + "\n\n");



            System.Console.WriteLine("-------------------------------------- Third Question (10) --------------------------------------------------------\n");

            System.Console.WriteLine("Input a four digit number\n");

            int inputNumber = int.Parse(System.Console.ReadLine());


            int four = inputNumber % 10;
            int three = (inputNumber / 10) % 10;
            int two = (inputNumber / 100) % 10;
            int one = (inputNumber / 1000) % 10;

            System.Console.WriteLine("First digit is: " + one);
            System.Console.WriteLine("Second digit is: " + two);
            System.Console.WriteLine("third digit is: " + three);
            System.Console.WriteLine("fourth digit is: " + four);
            System.Console.WriteLine("");

            int outputNumber = four + three + two + one;
            System.Console.WriteLine("Sum of digits is: " + outputNumber);
            System.Console.WriteLine("");

            outputNumber = (four * 1000) + (three * 100) + (two * 10) + one;
            System.Console.WriteLine("Number in reverse is: " + outputNumber);
            System.Console.WriteLine("");

            outputNumber = (four * 1000) + (two * 100) + (three * 10) + one;
            System.Console.WriteLine("Swapping first and last digits: " + outputNumber);
            System.Console.WriteLine("");

            outputNumber = (one * 1000) + (three * 100) + (two * 10) + four;
            System.Console.WriteLine("Swapping second and third digits: " + outputNumber);
            System.Console.WriteLine("");







        }
    }
}
