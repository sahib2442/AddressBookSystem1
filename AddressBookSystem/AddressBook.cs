using AddressBook;
using System;
using System.Collections.Generic;
namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Contact> contact = new List<Contact>();
        public static void AddPerson()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter first name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter mobile number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter state");
            contact.State = Console.ReadLine();
            contact.AddContact(contact);
        }
        public static void Editperson()
        {
            Console.WriteLine("Enter the name of the person you whould like to edit");
            string name = Console.ReadLine();
            Contact person = AddressBook.FirstOrDefault(x => x.name.ToLover() == name.ToLover());
            if (person == null)
            {
                Console.WriteLine("That person could not be found . press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want edit this person from your address book? (y/n)");
            AddressBook.AddPerson(Contact);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("Enter new details");
                AddressBook.Editperson(person);
                Editperson();
            }
        }
    }
}
