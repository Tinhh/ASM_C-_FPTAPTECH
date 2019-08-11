using System;
using System.Collections;
using System.Collections.Generic;
namespace asm2
{
    public class Cart
    {
        public int id;
        public int customer;
        public int grandtotal;
        public List<Product> ProductList;
        public string city;
        public string country;

        public delegate void AddMore();
        
        public bool AddToCart(Product p)
        {
            if (ProductList.Contains(p) && p.CheckQty())
            {
                ProductList.Add(p);
                p.qty--;
                grandtotal += p.price;
                return true;
            }
            return false;
        }
        public bool Delete(Product p)
        {
            if (ProductList.Contains(p))
            {
                ProductList.Remove(p);
                p.qty++;
                grandtotal -= p.price;
                return true;
            }
            Console.WriteLine("Product removed");
            return false;
        }

        public decimal GetGrandTotal()
        {
            decimal finalTotal = 0;
            if (country == "VN")
            {
                if (city == "HN" || city == "HCM")
                {
                    finalTotal = grandtotal * (decimal) 1.01;
                }
                else
                {
                    finalTotal = grandtotal * (decimal) 1.02;
                }
            }
            else
            {
                finalTotal = grandtotal * (decimal) 1.05;
            }

            return finalTotal;
        }
    }
}