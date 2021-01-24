using System;
using System.Threading;

namespace MultiThreading_demo1
{
    public class UsingJoinMethod
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start();t2.Start();t3.Start();
            //now the main thread will exit even before the thread1 ,2 and 3 will exit

            // to avoid this problem using join()  function

            t1.Join();t2.Join();t3.Join();



            // paramterized join method


            t1.Join(3000);
            // in this case main thread will only wait for 3 seconds for the t1 thread. if t1 is done 3 seconds , good. if not main thread will exit


        }


        static void Test1()
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
        }


        static void Test2()
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2: " + i);

                //if (i == 50)
                //{
                //    Console.WriteLine("Sleeping");
                //    Thread.Sleep(5000);
                //    Console.WriteLine("wake up");
                //}
            }
        }


        static void Test3()
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test3: " + i);
            }
        }
    }
}
