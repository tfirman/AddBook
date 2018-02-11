using System.Collections.Generic;

namespace AddBook.Models
{
    public class Contact
    {
        private string _name;
        private long _phoneNumber;
        private Address _address;
        private int _id;
        private static int ID = 0;

        private static List<Contact> _instances = new List<Contact>();

        public Contact(string name, long phoneNumber, string streetAddress, string city, string state, int zipCode)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _instances.Add(this);
            _id = ID++;
            _address = new Address(streetAddress, city, state, zipCode, _id);
        }

        public string GetName()
        {
            return _name;
        }

        public long GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public static List<Contact> GetAll()
        {
            return _instances;
        }

        public int GetId()
        {
            return _id;
        }

        public static Contact GetById(int id)
        {
            foreach (Contact contact in _instances)
            {
                if (contact.GetId() == id)
                {
                    return contact;
                }
            }
            return null;
        }

        public static void DeleteList()
        {
            _instances = new List<Contact>();
        }

        public static void RemoveById(int id)
        {
            foreach (Contact contact in _instances)
            {
                if (contact.GetId() == id)
                {
                    _instances.Remove(contact);
                }
            }
        }

    }
}
