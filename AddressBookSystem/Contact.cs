﻿using System;
namespace AddressBook
{
    public class Contact
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zib { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        internal void Addperson(Contact contact)
        {
            throw new NotImplementedException();
        }

        internal void DeleteContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        internal void EditPerson(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
