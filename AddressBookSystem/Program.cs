using AddressBook;
using System;
namespace AddressBookSystem
{
    class program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            {
                FirstName  = Console.ReadLine();
                LastName  = Console.ReadLine();
            };
            Console.WriteLine(contact.FirstName + "\n " + contact.LastName);
            Contact contact1 = new Contact();
            contact1.FirstName = Console.ReadLine();
            contact1.LastName = Console.ReadLine();
        }
    }
}
