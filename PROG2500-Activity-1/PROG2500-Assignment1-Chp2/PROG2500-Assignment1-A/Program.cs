using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_Assignment1_A
{
    
    //declare a variable ismale of type bool and assign a value
    //    to it depending on your gender.





    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Hello C#!");

            System.Console.WriteLine("-------------------------------------- First Question (2) --------------------------------------------------------");


            System.Console.WriteLine("For the following values: 5, -5.01, 34.567839023, 12.345; 8923.1234857; 3456.091124875956542151256683467");
            System.Console.WriteLine("Can only be stored in types that will allow due to size");

            decimal d1 = 5m;
            decimal d2 = -5.01m;
            decimal d3 = 34.567839023m;
            decimal d4 = 12.345m;
            decimal d5 = 8923.1234857m;
            decimal d6 = 3456.091124875956542151256683467m;
             
            System.Console.WriteLine("Decimal can store all of the following: " +d1 + " , " + d2 + " , " + d3 + " , " + d4 + " , " + d5 + " , " + d6);

            double do1 = 5d;
            double do2 = -5.01d;
            double do3 = 34.567839023d;
            double do4 = 12.345d;
            double do5 = 8923.1234857d;

            System.Console.WriteLine("Double can store all of the following: " +do1 + " , " + do2 + " , " + do3 + " , " + do4 + " , " + do5);

            float f1 = 5f;
            float f2 = -5.01f;
            float f4 = 12.345f;

            System.Console.WriteLine("Float can store all of the following: " + f1 + " , " + f2 + " , " + f4);

            System.Console.WriteLine("-------------------------------------- Second Question (6) --------------------------------------------------------");


            bool gender = true; 

            if (gender == true)
            {
                System.Console.WriteLine("My Gender is Male Bool is " + gender);

            }

            System.Console.WriteLine("-------------------------------------- Third Question (7) --------------------------------------------------------");

            string first = "brandon";
            string last = "debison";
            object fullName = "";

            System.Console.WriteLine(first + " " + last);
            fullName = first + " " + last;

            System.Console.WriteLine("Putting full name into object: " + fullName); 



        }
    }
}
