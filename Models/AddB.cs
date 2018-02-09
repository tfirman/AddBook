using System.Collections.Generic;

namespace AddBook.Models
{
    public class Contact
    {
        private string _name;
        private int _phoneNumber;
        private string _address;
        private int _id;
        private static int ID = 0;

        private static List<Contact> _instances = new List<Contact>();

        public Contact(string name, int phoneNumber, string address = "")
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _address = address;
            _instances.Add(this);
            _id = ID++;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public string GetAddress()
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
    }
}
