using System;
using System.Collections.Generic;

namespace InventorySystem
{
    public class Product
    {
        public string Name { get; set; }
        public int Qty {get; set;}
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Category {get; set;}
        public Product(string name , int qty ,double price , int stock , string category)
        {
            Name = name;
            Qty = qty;
            Price = price;
            Stock = stock;
            Category = category;
        }
    }

    public class PhysicalProduct:Product
    {
        public PhysicalProduct (string name , int qty ,double price , int stock , string category,string code)
        :base(name , qty , price , stock , category)
        {

        }
    }

    public class VirtualProduct : Product
    {
        public string Code{get; set;}
        public class VirtualProduct (string name , int qty ,double price , int stock , string category,string code)
        :base(name , qty , price , stock , category)
        {
            Code = code;
        }
    }

}
