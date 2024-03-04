using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace b
{
    public class AddressBook
    {
        //List<ContactPerson> ls = new List<ContactPerson>();
        string path = "F:\\file1.txt";






        public void AddContact(string m1, string m2, string m3, string m4, string m5, string m6,string m7)
        {
            
            string contactInfo = $"{m1},{m2},{m3},{m4},{m5},{m6},{m7}";
            using (StreamWriter writer = File.AppendText(path))
            {
               
               writer.WriteLine(contactInfo);
            }

            Console.WriteLine("Contact added successfully!");
        }




        public void EditContact(string firstName, string lastName)
        {
           
            string[] lines = File.ReadAllLines(path);

            
            bool contactFound = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] s = lines[i].Split(',');
                if (s[0].Equals(firstName) && s[1].Equals(lastName))
                {
                    Console.WriteLine($"Editing contact: {firstName} {lastName}");

                   
                    Console.Write("Enter new Address: ");
                    string newAddress = Console.ReadLine();
                    Console.Write("Enter new City: ");
                    string newCity = Console.ReadLine();
                    Console.Write("Enter new Zip: ");
                    string newZip = Console.ReadLine();
                    Console.Write("Enter new Phone Number: ");
                    string newPhoneNumber = Console.ReadLine();
                    Console.Write("Enter new Email: ");
                    string newEmail = Console.ReadLine();

                  
                    lines[i] = $"{firstName},{lastName},{newAddress},{newCity},{newZip},{newPhoneNumber},{newEmail}";
                    contactFound = true;
                    Console.WriteLine("Contact updated successfully!");
                    break;
                }
            }

            if (!contactFound)
            {
                Console.WriteLine($"Contact with name {firstName} {lastName} not found.");
            }

            
            File.WriteAllLines(path, lines);
        }

        public void DeleteContact(string firstName, string lastName)
        {
            
            List<string> lines = new List<string>(File.ReadAllLines(path));

            
            bool contactFound = false;
            for (int i = 0; i < lines.Count; i++)
            {
                string[] contactInfo = lines[i].Split(',');
                if (contactInfo[0].Equals(firstName) && contactInfo[1].Equals(lastName))
                {

                    Console.WriteLine($"Deleting contact: {firstName} {lastName}");


                    lines.RemoveAt(i);
                    contactFound = true;
                    Console.WriteLine("Contact deleted successfully!");
                    break;
                }
            }

            if (!contactFound)
            {
                Console.WriteLine($"Contact with name {firstName} {lastName} not found.");
            }

            
            File.WriteAllLines(path, lines);
        }

        public void DisplayContacts()
        {
            
           string[] lines = File.ReadAllLines(path);
            if(lines == null)
            {
                Console.WriteLine("empty addressbook!");
            }
            else
            {
                Console.WriteLine("Address Book Contacts:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            


        }
    }







}
