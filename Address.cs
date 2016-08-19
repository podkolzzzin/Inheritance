using System;

namespace Inheritance
{
    class Address : IEquatable<Address>
    {
        string Country;
        string City;
        string Street;
        int House,Flat;

        public Address(string country, string city, string street, int house, int flat)
        {
            Country = country;
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }

        public object Clone()
        {
            return new Address(this.Country, this.City, this.Street, this.House, this.Flat);
        }

        public bool Equals(Address other)
        {
            if (this.Country == other.Country &&
                this.City == other.City)
                return true;
            else
                return false;
        }

        public static bool operator == (Address that, Address other)
        {
            if (that.Country == other.Country &&
                that.City == other.City)
                return true;
            else
                return false;
        }

        public static bool operator !=(Address that, Address other)
        {
            return !(that == other);
        }
    }
}