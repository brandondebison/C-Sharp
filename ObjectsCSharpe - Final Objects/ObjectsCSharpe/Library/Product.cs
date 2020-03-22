using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsCSharpe.Library
{
    public class Product
    {

        public Product()
        {
            this.productId = 0;
            this.productName = "";
            this.productDescription = "";
            this.price = 10.00;
            this.test = "product";


        }

        ~Product()
        {
        }

        public Product(int i1, string s1, string s2, double d1)
        {
            this.productId = i1;
            this.productName = s1;
            this.productDescription = s2;
            this.price = d1;

        }

        public void Display()
        {
            Console.WriteLine("Product Id : " + this.productId + ", Product Name : " + this.productName + ", Product Description : " + this.productDescription + ", Price : " + this.price);
        }

        public int productId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public double price { get; set; }
        public string test { get; set; }


    }
}
