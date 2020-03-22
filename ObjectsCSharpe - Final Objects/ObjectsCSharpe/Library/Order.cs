using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsCSharpe.Library;


namespace ObjectsCSharpe.Library
{
     class Order
    {

        static public List<OrderLineItems> testLineItems = new List<OrderLineItems>();
        

        public Order()
        {
            this.orderId = 1;
            this.orderTotal = 1.00;
            this.orderDate = DateTime.Now.ToString();
            this.customer = new Customer();
            this.lineItems = testLineItems;

            test = "order";

        }

        public Order(int i1, double d1, string s1, Customer c1, OrderLineItems o1)
        {
            this.orderId = 0;
            this.orderTotal = 1.00;
            this.orderDate = DateTime.Now.ToString();
            this.customer = new Customer();

        }
        


        public void Display()
        {
            Console.WriteLine("Order Id : " + this.orderId + ", Date : " + this.orderDate + ", Customer " + this.customer.firstName + ", Order total = " + this.orderTotal);

        }

        public  void getTotal()
        {
            double total = 0.00;
            for (int i = 0; i < this.lineItems.Count(); i++)
            {
                total = this.lineItems[i].lineTotal + total;
            }
            this.orderTotal = total;

        }

        public void addLineItem(Product choice)
        {

            OrderLineItems tempLine = new OrderLineItems();
            tempLine.orderID = this.orderId;
            tempLine.product = choice;
            tempLine.lineNumber = this.lineItems.Count() + 1;
            Console.WriteLine("How Much do you want? ");
            tempLine.quantity = int.Parse(Console.ReadLine());
            tempLine.lineTotal = tempLine.quantity * tempLine.product.price;
            this.lineItems.Add(tempLine);

        }

        public void removeLineItem( int position)
        {
            this.lineItems.RemoveAt(position);
            this.getTotal();
        }

        public int orderId { get; set; }
        public double orderTotal { get; set; }
        public string orderDate { get; set; }
        public Customer customer { get; set; }
        public List<OrderLineItems> lineItems { get; set; }



        //public OrderLineItems addLineItems { get; set; }

        public string test { get; set; }



    }
}
