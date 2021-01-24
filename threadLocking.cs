using System;
using System.Threading;
namespace MultiThreading_demo1
{
    public class threadLocking
    {
        public static void Main(string[] args)
        {
            threadLocking obj = new threadLocking();
            //obj.Display();
            //obj.Display();
            //obj.Display();


            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
            t3.Start();

            // locking mechanism




        }

        public void Display()
        {
            // multiple threads cannot access this resource at the same time. Without unexpected results 
            lock (this)
            {
                Console.Write("CSharp is an");

                Thread.Sleep(5000);

                Console.WriteLine(" Object Oriented Programming language");
                hello();
            }
         
        }

        public void hello()
        {
            Console.Write(" hello ");
        }

    }
}
