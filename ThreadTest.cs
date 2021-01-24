using System;
using System.Threading;
namespace MultiThreading_demo1
{
    public class ThreadTest
    {


        static void Test1()
        {

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test1: " + i);
            }

            Console.WriteLine("Thread 1 is exiting -------------");
        }


        static void Test2()
        {

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test2: " + i);

                if (i == 25)
                {
                    Console.WriteLine("Sleeping thread 2-------------");
                    Thread.Sleep(15000);
                    Console.WriteLine("wake up thread 2--------------");
                }

            }

            Console.WriteLine("Thread 2 is exiting -------------");
        }


        static void Test3()
        {

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test3: " + i);
            }

            Console.WriteLine("Thread 3 is exiting -------------");
        }

        public static void Main(string[] args)
        {
            // these are the three child threads
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);


            // now you have to start the thread


            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread is exiting -------------");
        }
    }
}
