using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace b
{
    public class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        public ContactPerson(string FirstName, string LastName, string Address, string City, string Zip, string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}, {City}, {Zip}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine();
        }



    }
}
