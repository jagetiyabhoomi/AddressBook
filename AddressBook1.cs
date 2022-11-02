using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AdressBook1
    {
        private List<Person> adressBookList = new List<Person>();
        public List<Person> AdressBookList
        {
            get { return adressBookList; }
            set { this.adressBookList = value; }
        }


        public AdressBook1()
        {
            AdressBookList = new List<Person>();
        }

        public void CreateUser()
        {
            Console.WriteLine("Enter firstName:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter lastName:");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter adress:");
            var adress = Console.ReadLine();

            Console.WriteLine("Enter city:");
            var city = Console.ReadLine();

            Console.WriteLine("Enter state:");
            var state = Console.ReadLine();

            Console.WriteLine("Enter Postal code:");
            var pincode = Console.ReadLine();

            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();

            Console.WriteLine("Enter Phone no.:");
            var phone = Console.ReadLine();

            Person person = new Person(firstName, lastName, adress, city, state, pincode, email, phone);
            AddPersonToList(person);

        }
        private void AddPersonToList(Person person) => AdressBookList.Add(person);

       
        public void RemovePersonFromList()
        {
            Console.WriteLine("Enter firstName of the user you want to remove");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter lastname of the user you want to remove");
            var lastName = Console.ReadLine();

            AdressBookList.RemoveAll(item => item.Fname == firstName && item.Lname == lastName);
        }

        public void ShowAllPersonsInList()
        {
            foreach (var person in AdressBookList)
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("\nFirstName: {0}, \nLastName: {1}, \nAdress: {2}, \nCity: {3}, \nState: {4}, \nPostal Code: {5}, \nEmail: {6}, \nPhone no: {7} ", person.Fname, person.Lname, person.Address, person.City, person.State, person.PostalCode, person.email, person.phone);
            }
        }

        public void UpdateUserInformation()
        {
            Console.WriteLine("Which information do you want to update?");
            Console.WriteLine("#1: Firstname, #2: Lastname, 3# Adress 4# City 5# State 6# Pincode 7# email 8# phone");
            var userOption = Console.ReadLine();

            Console.WriteLine("Enter firstname on existing user to be updated");
            var oldFirstName = Console.ReadLine();
            UpdateUserFunction(userOption, oldFirstName);
        }

        private void UpdateUserFunction(string userOption, string oldFirstName)
        {
            var personsWithMatchingFirstName = AdressBookList.Where(person => person.Fname == oldFirstName);
            string newValue;

            if (userOption == "1")
            {
                Console.WriteLine("Enter a new first Name");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Fname = newValue;
                }
            }
            else if (userOption == "2")
            {
                Console.WriteLine("Enter a new last name");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Lname = newValue;
                   
                }
            }
            else if (userOption == "3")
            {
                Console.WriteLine("Enter a new adress");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Address = newValue;
              
                }
            }
            else if (userOption == "4")
            {
                Console.WriteLine("Enter a new city");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.City = newValue;

                }
            }
            else if (userOption == "5")
            {
                Console.WriteLine("Enter a new state");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.State = newValue;

                }
            }
            else if (userOption == "6")
            {
                Console.WriteLine("Enter a new Postal code");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.PostalCode = newValue;

                }
            }
            else if (userOption == "7")
            {
                Console.WriteLine("Enter a new email id");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.email = newValue;

                }
            }
            else if (userOption == "8")
            {
                Console.WriteLine("Enter a new phone no.");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.phone = newValue;

                }
            }
        }
    }
}
    

