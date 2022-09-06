using AddressBook;
using System;
namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Contact> contact = new List<Contact>();
        public static void AddContacts()
        {
            Console.WriteLine("\n select program \n 1.FirstName 2.LastName 3.Address 4.City 5.State 6.Zip 7.PhoneNo 8.Email");
            AddressBook addressBook = new AddressBook();
            while (addressBook == null)
            {
                Console.WriteLine("\n select program \n 1.AddPerson 2.EditPerson 3.DeletePerson");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Contact contact = new Contact();
                        {
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
                            contact.Addperson(contact);
                            break;
                        }
                    case 2:
                        {
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
                            contact.EditPerson(contact);
                            break;
                        }
                    case 3:
                        {
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
                            contact.DeleteContact(contact);
                            break;
                        }
                }
            }
        }
    }
}
