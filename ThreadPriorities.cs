using System;
using System.Threading;
namespace MultiThreading_demo1
{
    public class ThreadPriorities
    {
        static long Count1;
        static long Count2;


        public static void IncrementCount1()
        {
            while(true)
            {
                Count1++;
            }
        }


        public static void IncrementCount2()
        {
            while (true)
            {
                Count2++;
            }
        }


        public static void Main(string[] args)

            /////////////Threads Working with same Priority//////////////////////
        {

            Console.WriteLine("Thread Priorities");
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);


            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();

            Console.WriteLine("---thread sleep---");

            Thread.Sleep(10000);

            Console.WriteLine("-----Thread woke up----");
            t1.Abort();
            t2.Abort();


            Console.WriteLine("Count1 : " + Count1);
            Console.WriteLine("Count2 : " + Count2);

            ////////////////////////////////////////////////////////////////////
        }

    }
}
