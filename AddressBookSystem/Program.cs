using AddressBook;
using System;
namespace AddressBookSystem
{
    class program
    {
        private static object obj;

        public static string? FirstName { get; private set; }
        public static string? LastName { get; private set; }
        public static object op { get; private set; }

        static void Main(string[] args)
        {
            Contact? contact = new Contact();
            {
                FirstName  = Console.ReadLine();
                LastName  = Console.ReadLine();
            };
            Console.WriteLine(contact.FirstName + "\n " + contact.LastName);
            Contact? contact1 = new Contact();
            while (contact == null)
            {
                Console.WriteLine("\n select program \n 1.AddPerson 2.EditPerson 3.DeletePerson");
                int? option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Addperson");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the EditPerson");
                        Console.ReadLine();
                        break ;
                    case 3:
                        Console.WriteLine("Enter the DeletePerson");
                        Console.ReadLine();
                        break ;
                }
            }


        }
    }
}
