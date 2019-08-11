using System;

namespace asm4
{
    public class ManagePhoneBook
    {
        public static void Main(string[] arg)
        {
            PhoneBook p = new PhoneBook();
            bool start = true;
            while (start)
            {
                ShowMenu();
                int menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:p.InsertPhone(Console.ReadLine(),Console.ReadLine()) ;break;
                    case 2:p.RemovePhone(Console.ReadLine()) ;break;
                    case 3:p.UpdatePhone(Console.ReadLine(),Console.ReadLine()) ;break;
                    case 4: p.SearchPhone(Console.ReadLine()) ;break;
                }
            }
            
        }
        

        static void ShowMenu()
        {
            Console.WriteLine("1.Insert phone.");
            Console.WriteLine("2.Remove phone.");
            Console.WriteLine("3.Update phone.");
            Console.WriteLine("4.Search phone."); 
        }
    }
}