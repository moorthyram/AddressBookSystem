using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    internal class AddressBook
    {
        List<Person> listOfContacts = new List<Person>();
        Dictionary<string, List<Person>> listOfBooks = new Dictionary<string, List<Person>>();

        public void AddContacts(string addressBookName, int numOfContacts)
        {
            Person person = new Person();
            int count = 0;
            while (true)
            {
                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();
                Console.Write("Enter City: ");
                person.City = Console.ReadLine();
                Console.Write("Enter State: ");
                person.State = Console.ReadLine();
                Console.Write("Enter Zip: ");
                person.Zipcode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Email ID: ");
                person.Email = Console.ReadLine();
                listOfContacts.Add(person);
                count++;
                if (count == numOfContacts)
                {
                    listOfBooks.Add(addressBookName, listOfContacts);
                    break;
                }
            }
        }
        public void DisplayContacts()
        {
            foreach (var vall in listOfContacts)
            {
                Console.WriteLine("\nthis is the details of person in Address Book.");
                Console.WriteLine("\nFirst name : " + vall.FirstName + "\nLast name : " + vall.LastName + "\nCity : " + vall.City + "\nState : " + vall.State + "\nZip code : " + vall.Zipcode + "\nPhoneNumber : " + vall.PhoneNumber + "\nEmail ID : " + vall.Email + "\n");
            }
        }

        public void EditContacts()
        {
            Console.WriteLine("To edit the contact list enter the firstname of the person");
            string editName = Console.ReadLine();
            foreach (var vall in listOfContacts)
            {
                if (editName == vall.FirstName)
                {
                    Console.WriteLine("To edit contacts enter\n1.Lastname\n2.City\n3.State\n4.Zip\n5.PhoneNumber\n6.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string lastName = Console.ReadLine();
                            vall.LastName = lastName;
                            break;
                        case 2:
                            string city = Console.ReadLine();
                            vall.City = city;
                            break;
                        case 3:
                            string state = Console.ReadLine();
                            vall.State = state;
                            break;
                        case 4:
                            int zip = Convert.ToInt32(Console.ReadLine());
                            vall.Zipcode = zip;
                            break;
                        case 5:
                            int phone = Convert.ToInt32(Console.ReadLine());
                            vall.PhoneNumber = phone;
                            break;
                        case 6:
                            string email = Console.ReadLine();
                            vall.Email = email;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input as described in above line.");
                            break;
                    }
                }
            }
        }
    }
}
