using System;
using System.Collections.Generic;
namespace InventorySystem
{
    class Store
    {
        private string name;
        private List<Product> inventory;

        public Store(string name)
        {
            this.name = name;
            inventory = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if(inventory.Add(product))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool RemoveProduct(string name)
        {
            foreach(Product product in inventory)
            {
                if(product.Name == name)
                {
                    inventory.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public bool ListProducts()
        {
            foreach (Product product in inventory)
            {
                Console.WriteLine(product.Name);
            }
            return true;
        }

        public int FindProductIndex(string name)
        {
            foreach(Product product in inventory)
            {
                if(product.Name == name)
                {
                    return inventory.IndexOf(product);
                }
            }
            return -1;
        }

        public int CalculateTotalValue()
        {
            int totalValue = 0;
            foreach(Product product in inventory)
            {
                totalValue += product.Price * product.Stock;
            }
            return totalValue;
        }

        public int CheckStock(string name)
        {
            foreach(Product product in inventory)
            {
                if(product.Name == name)
                {
                    return product.Stock;
                }
            }
            return -1;
        }
    }
}
