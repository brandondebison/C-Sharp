using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_Assignment1_Chp5
{
    class Program
    {
        static void Main(string[] args)
        {



            


                System.Console.WriteLine("-------------------------------------- First Question (1) --------------------------------------------------------\n");

            System.Console.WriteLine("Enter 2 numbers and they will be displayed in least to greatest\n");

            int intOne = int.Parse(Console.ReadLine());
            int intTwo = int.Parse(Console.ReadLine());
            int temp = 0;

            if ( intOne > intTwo)
            {
                temp = intOne;
                intOne = intTwo;
                intTwo = temp;
                System.Console.WriteLine("The lowest is " + intOne + " highest number is: " + intTwo);
            }

            System.Console.WriteLine("\n");




            System.Console.WriteLine("-------------------------------------- Second Question (3) --------------------------------------------------------\n");

            System.Console.WriteLine("Please enter 3 numbers, we will output the biggest\n");

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());



            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    System.Console.WriteLine("The biggest number is " + firstNumber);

                }
            }

            if (firstNumber < secondNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    System.Console.WriteLine("The biggest number is " + secondNumber);

                }
            }

            if (firstNumber < thirdNumber)
            {
                if (thirdNumber > secondNumber)
                {
                    System.Console.WriteLine("The biggest number is " + thirdNumber);

                }
            }




            System.Console.WriteLine("-------------------------------------- Third Question (10) --------------------------------------------------------\n");

           

            System.Console.WriteLine("Input a number between 1-9 to calculate the bonus points\n");
            int inputNumber = int.Parse(Console.ReadLine());


            int searchNumber = 0;

            if (inputNumber > 0 && inputNumber < 4)
            {
                searchNumber = 1;
            }

            if (inputNumber >= 4 && inputNumber < 7)
            {
                searchNumber = 2;
            }


            if (inputNumber >= 7 && inputNumber < 10)
            {
                searchNumber = 3;
            }





            switch (searchNumber) {

                case 1: System.Console.WriteLine("The score is: " + (inputNumber * 10)) ; break;
                case 2: System.Console.WriteLine("The score is: " + (inputNumber * 100)) ; break;
                case 3: System.Console.WriteLine("The score is: " + (inputNumber * 1000)) ; break;

                default: System.Console.WriteLine("Error, please enter between 0-9 " ); break;

            }

            






        }
    }
}
