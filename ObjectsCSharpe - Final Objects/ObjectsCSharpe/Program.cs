using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsCSharpe.Library;

namespace ObjectsCSharpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            int custID = 0;
            List<Customer> CustomerDataBase = new List<Customer>();
            List<Product> ProductDataBase = new List<Product>();
            Product tempProduct;


            // Populate the customer data base with a loop 
            Customer user1 = new Customer(1, "Peter", "Parker", "spidey@web.net", "987-654-3210", "20 Ingram Street", "Queens", "New York", "11365");
            CustomerDataBase.Add(user1);


            // Poplate the Product data base with a loop
            Product butter = new Product(1, "Butter", "Use it on toast", 3.99);
            ProductDataBase.Add(butter);

            Product milk = new Product(2, "2 Ltr Milk", "Use it in Coffee", 4.99);
            ProductDataBase.Add(milk);

            Product beer = new Product(3, "Island Time Beer", "Best Drank Cold", 7.99);
            ProductDataBase.Add(beer);


            // Create the Order sheet 
            Order orderSheet = new Order();

            Console.WriteLine("Do you have a customer Profile? Y or N");
            answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                Console.WriteLine("What is your ID? ");
                custID = int.Parse(Console.ReadLine());
                Customer selectedCustomer = CustomerDataBase[custID];
                orderSheet.customer = selectedCustomer;
            }
            else
            {
                Customer tempCustomer = Program.newCustomer();
                CustomerDataBase.Add(tempCustomer);
                orderSheet.customer = tempCustomer;
            }

            Console.WriteLine("This is what we have in the shop right now, select what you would like by entering the ID number and  ");
            for (int i = 0; i < ProductDataBase.Count(); i++)
            {
                ProductDataBase[i].Display();
            }


            int selection = 0;

            while (true)
            {

                selection = int.Parse(Console.ReadLine());

                if (selection > ProductDataBase.Count() || selection < 0) { Console.WriteLine("That is not a valid selection");
                } else {

                    orderSheet.addLineItem(ProductDataBase[selection-1]);

                    Console.WriteLine("Would you like something else? Y or N");
                    answer = Console.ReadLine();
                    if (answer == "n" || answer == "N") { orderSheet.getTotal(); break; }
                    Console.WriteLine("What would you like?");
                    for (int i = 0; i < ProductDataBase.Count(); i++)
                    {
                        ProductDataBase[i].Display();
                    }
                }
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            orderSheet.Display();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            for (int i = 0; i < orderSheet.lineItems.Count(); i++)
            {
                orderSheet.lineItems[i].Display();
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Did you want to remove anything from the order before submitting? ");
                orderSheet.Display();

                answer = Console.ReadLine();
                if (answer == "n" || answer == "N") { break;
                }
                else
                {
                    Console.WriteLine("Which line number do you want to remove? ");
                    selection = int.Parse(Console.ReadLine())-1;
                    if (selection > orderSheet.lineItems.Count() || selection < 0)
                    {
                        Console.WriteLine("That is not a valid selection");
                    }
                    else
                    {
                        orderSheet.removeLineItem(selection);
                        Console.WriteLine("Removed Line : " + selection);
                        for (int i = 0; i < orderSheet.lineItems.Count(); i++)
                        {
                            orderSheet.lineItems[i].Display();
                        }
                    }
                }

            }

            Console.WriteLine("Thanks for shopping");
            string end = Console.ReadLine();

        }

        public static Customer newCustomer()
        {
            Console.WriteLine("Lets setup a Customer Profile");

            Console.WriteLine("What is your First Name?");
            string cFirstName = Console.ReadLine();

            Console.WriteLine("What is your Last Name?");
            string cLastName = Console.ReadLine();

            Console.WriteLine("What is your Email?");
            string cEmail = Console.ReadLine();

            Console.WriteLine("What is your Phone Number?");
            string cPhone = Console.ReadLine();

            Console.WriteLine("What is your Street address?");
            string cStreet = Console.ReadLine();

            Console.WriteLine("What is your City?");
            string cCity = Console.ReadLine();

            Console.WriteLine("What is your Province?");
            string cProvince = Console.ReadLine();

            Console.WriteLine("What is your Postal Code?");
            string cPostal = Console.ReadLine();

            Customer newCustomer = new Customer(2, cFirstName, cLastName, cEmail, cPhone, cStreet, cCity, cProvince, cPostal);

            return newCustomer;
        }
        

        
    }

}
