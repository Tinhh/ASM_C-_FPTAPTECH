using System;
using System.Collections.Generic;
namespace asm3
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            bool start = true;
            List<News> list = new List<News>();
            while (start)
            {
                ShowMenu();
                int menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1: InsertNews(list);break;
                    case 2: AvgAndView(list);break;
                    case 3: AvgAndView(list,true);break;
                    case 4:
                        start = false;break;
                }
            }
        }

        static void AvgAndView(List<News> list, bool func = false)
        {
            foreach (News news in list)
            {
                if (func)
                {
                    news.Calculate();
                }
                news.Display();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Chon chuc nang");
            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Average rate");
            Console.WriteLine("4. Exit");
        }

        static void InsertNews(List<News> list)
        {
            Console.WriteLine("nhap id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap title:");
            string title = Console.ReadLine();
            Console.WriteLine("nhap date:");
            string pdate = Console.ReadLine();
            Console.WriteLine("nhap author:");
            string author = Console.ReadLine();
            Console.WriteLine("nhap content:");
            string content = Console.ReadLine();
            News ns = new News(id,title,pdate,author,
                content);
            Console.WriteLine("Nhap 3 gia tri rate:");
            for (int i = 0; i < 3; i++)
            {
                ns[i] = Convert.ToInt16(Console.ReadLine());
            }
            list.Add(ns);
        }
    }
}