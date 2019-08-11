using System;
using System.Threading;
namespace asm6
{
    public class Assignment6
    {    
        
        public static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Timer timer = new Timer();
            Thread t1 = new Thread(delegate()
            {
                for (; ;)
                {
                    lock (timer)
                    {
                        timer.sec = 0;
                        for (; timer.sec < 60; timer.sec++)
                        {
                            Console.WriteLine(timer.min.ToString("D2")
                                              +":"+ timer.sec.ToString("D2"));
                            Thread.Sleep(1000);
                        }

                        timer.min++;
                    }
                }
                
            });
            Thread t11 = new Thread(delegate()
            {
                while (true)
                {
                    lock (timer)
                    {
                        timer.sec = 0;
                        for (; timer.sec < 60; timer.sec++)
                        {
                            Console.WriteLine(timer.min.ToString("D2")
                                              +":"+ timer.sec.ToString("D2"));
                            Thread.Sleep(1000);
                        }

                        timer.min++;
                    }
                }
                
            });
            t1.IsBackground = true;
            t11.IsBackground = true;
            
            Fibo f = new Fibo();
            Thread t2 = new Thread(delegate()
            {
                for (; ; )
                {
                    lock (f)
                    {
                        if (f.x1 + f.x2 > n)
                        {
                            break;
                        }
                        f.x3 = f.x1 + f.x2;
                        f.x1 = f.x2;
                        f.x2 = f.x3;
                        Console.WriteLine("t2 - Fibo: " + f.x3);
                        Thread.Sleep(500);
                    } 
                }
            });
            Thread t22 = new Thread(delegate()
            {
                for (; ; )
                {
                    lock (f)
                    {
                        if (f.x1 + f.x2 > n)
                        {
                            break;
                        }
                        f.x3 = f.x1 + f.x2;
                        f.x1 = f.x2;
                        f.x2 = f.x3;
                        Console.WriteLine("t22 - Fibo: " + f.x3);
                        Thread.Sleep(500);
                    } 
                }
            });
            t1.Start();
            t11.Start();
            t2.Start();
            t22.Start();
        }
    }

    public class Fibo
    {
        public int x1 = 1;
        public int x2 = 1;
        public int x3 = 2;
    }

    public class Timer
    {
        public int min = 0;
        public int sec = 0;
    }
}