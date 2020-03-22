using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsCSharpe.Library;


namespace ObjectsCSharpe.Library
{
     public class OrderLineItems
    {


        public OrderLineItems()
        {
            this.orderID = 0;
            this.lineNumber = 0;
            this.product = new Product();
            this.quantity = 0;
            this.lineTotal = 0.00;
        }

        ~OrderLineItems()
        {
        }

        public OrderLineItems(int i1, int i2, int i3 )
        {
            this.orderID = i1;
            this.lineNumber = i2;
            this.product = new Product();
            this.quantity = i3;
            this.lineTotal = 0.00;
        }

        public void Display()
        {
            string product = this.product.productName;
            Console.WriteLine("Order ID : " + this.orderID + ", Line Number : " + this.lineNumber + ", Product Name : " + product + ", Line Total : " + this.lineTotal, ", Quantity : " + this.quantity);

        }

        public int orderID { get; set; }
        public int lineNumber { get; set; }
        public Product product { get; set; }
        public int quantity { get; set; }
        public double lineTotal { get; set; }





    }
}
