using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2400_Activity_Chp7
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("-------------------------------------- First Question (1) --------------------------------------------------------\n");


           System.Console.WriteLine("Enter a number to set the array calculation to\n");


            int inputQOne = int.Parse(Console.ReadLine());

            int[] myArray = new int[20];

            for (int i=0; i < 20; i++ )
            {
                myArray[i] = (inputQOne * 5);
            }

            for (int j = 0; j < 20; j++)
            {
                System.Console.WriteLine("Position: " + (j+1) + " is " + myArray[j]);
            }



            System.Console.WriteLine("\n");




            System.Console.WriteLine("-------------------------------------- Second Question (2) --------------------------------------------------------\n");



            System.Console.WriteLine("Lets check if these 2 arrays are the same\n");

            int[] myArray2 = new int[10];
            int[] myArray3 = new int[10];
            bool errorTest = false;

            for (int i = 1; i < 10; i++)
            {
                myArray2[i] = 2;
                myArray3[i] = 2;
            }

            for (int i = 1; i < 10; i++)
            {
                if (myArray2[i] != myArray3[i]) { Console.WriteLine("Error Found at position: " + i + " " + myArray2[i] + " " + myArray3[i]); errorTest = true; }
            }

            myArray2[5] = 3;

            
            for (int i = 1; i < 10; i++)
            {
                if (myArray2[i] != myArray3[i]) { Console.WriteLine("Error Found at position: " + i + " array 1: " + myArray2[i] + " array 2: " + myArray3[i]); ; errorTest = true; }
            }
            

            System.Console.WriteLine("\n");



            System.Console.WriteLine("-------------------------------------- Third Question (10) --------------------------------------------------------\n");

            System.Console.WriteLine("Lets check if these 2 arrays are the same\n");

            char[] myArray4 = new char[10];
            char[] myArray5 = new char[10];
            bool errorTest2 = false;

            for (int i = 1; i < 10; i++)
            {
                myArray4[i] = 'r';
                myArray5[i] = 'r';
            }

            for (int i = 1; i < 10; i++)
            {
                if (myArray4[i] != myArray5[i]) { Console.WriteLine("Error Found at position: " + i + " " + myArray4[i] + " " + myArray5[i]); errorTest2 = true; }
            }

            myArray5[5] = 's';


            for (int i = 1; i < 10; i++)
            {
                if (myArray4[i] != myArray5[i]) { Console.WriteLine("Error Found at position: " + i + " array 4: " + myArray4[i] + " array 5: " + myArray5[i]); errorTest2 = true; }
            }


            System.Console.WriteLine("\n");
            System.Console.ReadLine();




        }
    }
}
