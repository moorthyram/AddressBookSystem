namespace AddressBookProblem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System");
            AddressBook addressbook = new AddressBook();

            Console.WriteLine("Enter the below mentioned number\n1:Add Contacts.\n2:Display Contacts\n3:Edit Contacts.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter how many contacts you wish to add in AddressBook.");
                    string addressBookName = Console.ReadLine();
                    Console.WriteLine("how many contacts do you want to add?");
                    int numOfContacts = Convert.ToInt32(Console.ReadLine());
                    addressbook.AddContacts(addressBookName, numOfContacts);
                    break;
                case 2:
                    Console.WriteLine("Displaying addressbook");
                    break;
                case 3:
                    Console.WriteLine("Edit addressbook");
                    break;

                default:
                    Console.WriteLine("please enter valid number");
                    break;
            }
            Console.ReadLine();
        }

    }
}