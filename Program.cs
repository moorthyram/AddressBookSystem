namespace AddressBookProblem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System");
            AddressBook addressbook = new AddressBook();
            Console.WriteLine("Enter the below mentioned number\n1:Add Contacts.");
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
            }
            Console.ReadLine();
        }

    }
}