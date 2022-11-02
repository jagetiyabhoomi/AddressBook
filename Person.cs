using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{

    public class Person
    { 

        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public Person(string fname, string lname, string address, string city, string state, string postalCode, string email, string phone)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.email = email;
            this.phone = phone;
        }
    }
}
