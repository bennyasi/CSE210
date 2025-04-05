using System;

namespace OnlineOrdering
{
    public class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public bool LivesInUSA()
        {
            return address.IsUSA();
        }

        public string GetShippingLabel()
        {
            return $"{name}\n{address.GetFullAddress()}";
        }
    }
}
