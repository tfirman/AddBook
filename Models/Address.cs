using System.Collections.Generic;

namespace AddBook.Models
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private int _zipCode;
        private int _id;
        private static List<Address> _addresses = new List<Address>();

        public Address(string streetAddress, string city, string state, int zipCode, int id)
        {
            _streetAddress = streetAddress;
            _city = city;
            _state = state;
            _zipCode = zipCode;
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public static Address GetById(int id)
        {
            foreach (Address address in _addresses)
            {
                if (address.GetId() == id)
                {
                    return address;
                }
            }
            return null;
        }

        public string GetStreetAddress()
        {
            return _streetAddress;
        }

        public string GetCity()
        {
            return _city;
        }

        public string GetState()
        {
            return _state;
        }

        public int GetZipCode()
        {
            return _zipCode;
        }

    }
}
