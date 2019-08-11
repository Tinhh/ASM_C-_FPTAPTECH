namespace T1809E_CSharp
{
    public delegate void Notification(string s);
    public class Cart
    {
        public int id;
        public class Cart
        public string city;
        public string country;

        private event Notification NotifyWhenAddProduct;

        public static void ShowNotification(string s)
        {
            Console.WriteLine(s);
        }

        public bool AddProduct(Product p)
        {
            if (!productList.Contains(p) && p.CheckQty())
            {    
                productList.Add(p);
                p.qty--;
                grandTotal += p.price;
                if (NotifyWhenAddProduct == null)
                {
                    NotifyWhenAddProduct += ShowNotification;
                }
                NotifyWhenAddProduct("San pham da duoc them vao gio hang");
                return true;
            }
            Console.WriteLine("san pham da co trong gio hang");
            return false;
        }
        public bool RemoveProduct(Product p)
        {
            if (productList.Contains(p))
            {
                productList.Remove(p);
                p.qty++;
                grandTotal -= p.price;
                return true;
            }
            Console.WriteLine("san pham khong co trong gio hang");
            return false;
        }
        public decimal GetGrandTotal()
        {
            decimal finalTotal;
            if (country == "VN")
            {
                if (city == "HN" || city == "HCM")
                {
                    finalTotal = grandTotal * (decimal)1.01;
                }
                else
                {
                    finalTotal = grandTotal * (decimal)1.02;
                }
            }
            else
            {
                finalTotal = grandTotal * (decimal)1.05;
            }
            return finalTotal;
        }
    }
}