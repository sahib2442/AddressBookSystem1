using AddressBook;
using System;
namespace AddressBookSystem
{
    class AddNewContact
    {
        static String? firstName;
        static String? lastName;
        static long? phoneNumber;
        static String? email;
        static String? address;
        static String? city;
        static String? state;
        static int zipCode;
        public static List<String> addressBook = new List<String>();

        // method for add new contact
        public static void AddNewContacts()
        {

            CreateContact(addressBook);
        }


        // method for creating contact in address book
        public static void CreateContact(List<string> addressBook)
        {
            int count = 0;
            string contact;
            char ch;
            do
            {
                Console.WriteLine("\nPlease Enter Contact Details: \n");
                ContactDeatils();
                Console.WriteLine("\nContact Created.\n");

                contact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
                addressBook.Add(contact);
                count++;

                Console.WriteLine("Do you want to continue: y/n");
                ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            }
            while (ch == 'y');


            Console.WriteLine("\n{0} contacts\n", count);

            for (int i = 0; i < addressBook.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i + 1, addressBook[i]);
            }
            toContinue();
        }

        private static void toContinue()
        {
            throw new NotImplementedException();
        }

        // method for taking user input from console for creating or updating a contact
        public static void ContactDeatils()
        {

            Console.Write("First Name : ");
            firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            lastName = Console.ReadLine();
            Console.Write("Phone Number : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email : ");
            email = Console.ReadLine(); ;
            Console.Write("Address : ");
            address = Console.ReadLine();
            Console.Write("City : ");
            city = Console.ReadLine();
            Console.Write("State : ");
            state = Console.ReadLine();
            Console.Write("Zip : ");
            zipCode = Convert.ToInt32(Console.ReadLine());
        }



        public static void ToContinue()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            char ch;
            Console.WriteLine("Do you want to continue: y/n");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n\n");
            if (ch == 'y')
            {
                AddNewContacts();
            }
            else
            {
                Environment.Exit(-1);
            }
            if (ch == 'y')
            {
                UpdateContact();
            }
            else
            {
                Environment.Exit(-1);
            }
            if (ch == 'y')
            {
                ContactDelete();
            }
            else
            {
                Environment.Exit(-1);
            }


            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
        }

        private static void ContactDelete()
        {
            throw new NotImplementedException();
        }

        private static void UpdateContact()
        {
            throw new NotImplementedException();
        }
         private static void getAddressBookByName()
        {
            Console.WriteLine("Enter Address Book Name to search");
            String bookName = object.nextline();
            Console.WriteLine(op.ToString());
        }
        public static bool UniqContact(String firstName)
        {
            var details = contact.GetType(firstName);
            if (details == null)
            {
                return true;
            }
            return false;
        }
        public void viewPersonByCity()
        {
            Console.WriteLine("Enter city");
            String location = object.Equals();
            obj.nextLine();
            int flag = 1;
            for (String entry; city.Equals())
            {
                if (entry.Equals(location)) 
                    Console.WriteLine(entry);
                flag = 0;
            }
            if (flag == 1) 
                Console.WriteLine("no records found");
        }

        public void viewPersonByState(string entry)
        {
            Console.WriteLine("Enter state");
            String location = object.Equals();
            object value = object.Equals();
            int flag = 1;
            for (String entry; state.keySet())
            {
                if (entry.Equals(location))
                    Console.WriteLine(entry);
                flag = 0;
            }
            if (flag == 1) 
                Console.WriteLine("no records found");
        }
         public void getContactByCityOrState()
        {
            Console.WriteLine("Enter city or state");
            String location = obj.next();
            object.nextLine();
            List check1 = state.GetType(location);
            List check2 = city.GetType(location);
            if (check1 != null)
                Console.WriteLine(state.GetType(location));
            else if (check2 != null)
                Console.WriteLine(city.GetType(location));
            else
                Console.WriteLine("no records found");
        }
         public void ReadFromStreamReader(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}

   
