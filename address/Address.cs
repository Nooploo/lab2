using System;

namespace ConsoleApp1
{
    internal class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public Address(int index, string country, string city, string street, string house, string apartment)
        {
            this.Index = index;
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.House = house;
            this.Apartment = apartment;
        }

        public void Print()
        {
            Console.WriteLine($"Index: {Index}\nCountry: " +
                $"{Country}\nCity: {City}\nStreet: {Street}\n" +
                $"House: {House}\nApartment: {Apartment}");
        }
    }
}
