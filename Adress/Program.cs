using System;

namespace Adress
{
    internal class Program
    {
        private class Address
        {
            private string index;
            private string country;
            private string city;
            private string street;
            private string house;
            private string apartment;

            public Address(string index, string country, string city, string street, string house, string apartment)
            {
                Index = index;
                Country = country;
                City = city;
                Street = street;
                House = house;
                Apartment = apartment;
            }

            public string Index
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

            public void Show()
            {
                Console.WriteLine("Index : " + Index);
                Console.WriteLine("Country : " + Country);
                Console.WriteLine("City : " + City);
                Console.WriteLine("Street : " + Street);
                Console.WriteLine("House : " + House);
                Console.WriteLine("Apartment : " + Apartment);
            }
        }

        private static void Main(string[] args)
        {
            Address address = new Address("41-500", "Ukraine", "Kharkiv", "Svobody", "1", "45");

            address.Show();

            Console.ReadLine();
        }
    }
}