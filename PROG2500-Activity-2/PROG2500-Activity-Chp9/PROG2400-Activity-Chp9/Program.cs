using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2400_Activity_Chp9
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("-------------------------------------- First Question (1) --------------------------------------------------------\n");

            getName();


            System.Console.WriteLine("\n");




            System.Console.WriteLine("-------------------------------------- Second Question (2) --------------------------------------------------------\n");

            int inputOne = 0;
            int inputTwo = 0;
            int inputThree = 0;
            int temp = 0;
            int max = 0;

            System.Console.WriteLine("Please enter 3 numbers to compare which is the biggest.\n");

            inputOne = int.Parse(Console.ReadLine());
            inputTwo = int.Parse(Console.ReadLine());
            inputThree = int.Parse(Console.ReadLine());


            temp = getMax(inputOne, inputTwo);

            max = getMax(temp, inputThree);

            System.Console.WriteLine("Max number is " + max);


            System.Console.WriteLine("\n");



            System.Console.WriteLine("-------------------------------------- Third Question (4) --------------------------------------------------------\n");


            System.Console.WriteLine("Lets check how many times a number is in an array\n");
            System.Console.WriteLine("Please enter a number better 1 -9\n");

            int numCheck = 0;
            int total = 0;

            int[] myArray = new int[] { 2, 4, 6, 1, 2, 4, 5, 6,1,3 };

            numCheck =  int.Parse(Console.ReadLine());


            total = getCount(myArray, numCheck);

            System.Console.WriteLine(numCheck + " Was found " + total + " times");

            System.Console.WriteLine("\n");
            System.Console.ReadLine();



        }

        public static void getName()
        {
            System.Console.WriteLine("Please enter your name\n");

            string inputName =  System.Console.ReadLine();
            System.Console.WriteLine("The name entered was " + inputName);

        }

       
        public static int getMax(int i1, int i2)
        {
            int maxNumber = 0;
            if (i1 > i2)
            {
                maxNumber = i1;
            } else
            {
                maxNumber = i2;
            }

            return maxNumber;
        }


        public static int getCount(int[] a1, int i1)
        {
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                if (a1[i] == i1)
                {
                    count = count + 1;
                }

            }

            return count;

        }

    }


    }

