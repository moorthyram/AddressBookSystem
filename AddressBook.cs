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
                person.PhoneNumber = Convert.ToDouble(Console.ReadLine());
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
    }
}
