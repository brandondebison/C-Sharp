using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsCSharpe.Library
{
    public class Customer
    {
        public Customer()
        {
            this.customerId = 0;
            this.firstName = "";
            this.lastName = "";
            this.emailAddress = "";
            this.phoneNumber = "";

            this.street = "";
            this.city = "";
            this.province = "";
            this.postalCode = "";

            this.test = "customer";

        }

        ~Customer()
        {
        }

        public Customer(int i1, string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8)
        {
            this.customerId = i1;
            this.firstName = s1;
            this.lastName = s2;
            this.emailAddress = s3;
            this.phoneNumber = s4;

            this.street = s5;
            this.city = s6;
            this.province = s7;
            this.postalCode = s8;

        }



        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }
        public string test { get; set; }



    }
}
