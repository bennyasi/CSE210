using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> products = new List<Product>();
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.GetTotalCost();
            }
            decimal shippingCost = customer.LivesInUSA() ? 5 : 35;
            total += shippingCost;

            // Apply discount if total before shipping is above $50
            if (total - shippingCost > 50)
            {
                total *= 0.9m; // Apply 10% discount
            }
            return total;
        }

        public string GetPackingLabel()
        {
            string label = "Packing List:\n";
            foreach (var product in products)
            {
                label += product.GetPackingLabel() + "\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return "Shipping To:\n" + customer.GetShippingLabel();
        }
    }
}
