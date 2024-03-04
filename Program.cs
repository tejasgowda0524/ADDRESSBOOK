using System.IO;
using System.Text.RegularExpressions;



namespace b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook ab = new AddressBook();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display Contacts");
                Console.WriteLine("5. Exit");

                
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter the data in this format Ex: name =Ramesh , last name = A,city = Mumbai , ZIP = 567-549 ,phonenumber = 9812346579, email =bangalore01@gmail.com ");
                        string namePattern = "[A-Z]{1}[a-z]";
                        string LnamePatter = "[A-Z]";
                        string cityPattermn = "[A-Z]{1}[a-z]";
                        string zipPattermn = "[0-9]{3}[-]{1}[0-9]{3}";
                        string pnpattern = "[8,7,6,9]{1}[0-9]{9}";
                        string mailpattern = "[a-z]{2,9}[0-9]{1,9}[@]{1}[a-z]{1,9}[.]{1}[a-z]{2,5}";

                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter City: ");
                        string city = Console.ReadLine();
                        Console.Write("Enter Zip: ");
                        string zip = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();



                        bool isName = Regex.IsMatch(firstName, namePattern);
                        bool isLname = Regex.IsMatch(lastName, LnamePatter);
                        bool isCity = Regex.IsMatch(city, cityPattermn);
                        bool iszip = Regex.IsMatch(zip, zipPattermn);
                        bool ispn = Regex.IsMatch(phoneNumber, pnpattern);
                        bool ismail = Regex.IsMatch(email, mailpattern);

                        Console.WriteLine(isName);
                        Console.WriteLine(isLname);
                        Console.WriteLine(isCity);
                        Console.WriteLine(iszip);
                        Console.WriteLine(ispn);
                        Console.WriteLine(ismail);
                        string a1 = null;
                        string a2 = null;
                        string b1 = null;
                        string b2 = null;
                        string b3 = null;
                        string b4 = null;

                        try
                        {
                            if(isName && isLname && isCity && iszip && ispn && ismail)
                            {
                                a1=firstName;
                                a2=lastName;
                                b1=city;
                                b2=zip;
                                b3 = phoneNumber;
                                b4 = email;

                               
                               // ContactPerson newContact = new ContactPerson(a1, a2, address, b1, b2, b3, b4);

                                ab.AddContact(a1, a2, address, b1, b2, b3, b4);
                            }
                            else
                            {
                                throw new invalidInput("exception has occured ..please check your input data");
                                //Console.WriteLine("enter valid format (Ex: city = Mumbai , ZIP = 567-549 ,phonenumber = 9812346579, email =bangalore01@gmail.com )");
                                
                            }
                        }
                        catch (invalidInput e)
                        {
                            Console.WriteLine(e.Message);
                        }


                        
                        break;

                    case 2:
                        
                        Console.Write("Enter First Name of Contact to Edit: ");
                        string editFirstName = Console.ReadLine();
                        Console.Write("Enter Last Name of Contact to Edit: ");
                        string editLastName = Console.ReadLine();

                        ab.EditContact(editFirstName, editLastName);
                        break;

                    case 3:
                        Console.Write("Enter First Name of Contact to Delete: ");
                        string deleteFirstName = Console.ReadLine();
                        Console.Write("Enter Last Name of Contact to Delete: ");
                        string deleteLastName = Console.ReadLine();

                        ab.DeleteContact(deleteFirstName, deleteLastName);
                        break;

                    case 4:
                        ab.DisplayContacts();
                        break;

                    case 5:
                        
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter the valid choice.");
                        break;
                }



            }
        }

    }
}
