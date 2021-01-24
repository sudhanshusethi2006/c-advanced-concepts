using System;
using System.Threading;
namespace MultiThreading_demo1
{
    public class ConstructorsOFThreadClass
    {
        public static void Main(string[] args)
        {
            // this is explicit 
            ThreadStart obj = new ThreadStart(Test1);

            Thread t1 = new Thread(obj);


            //we can also do

            Thread t2 = new Thread(Test1);

            // this is implicit
            // these both are same

            //-----------------------------


            //OR


            ThreadStart obj2 =  delegate ()
            {

                Test1();
            };


            Thread thread3 = new Thread(obj2);

            //Or by annonymous method

            ThreadStart obj4 = () => Test1();


            // Parameterized thread start

            ParameterizedThreadStart p = new ParameterizedThreadStart(Test2);

            Thread thread5 = new Thread(p);
            thread5.Start(25);


            Thread t = new Thread(Test2);
            t.Start(25);

            // Paramter has to be object type there fore it is not type safe
        }


        static void Test1()
        {

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test1: " + i);
            }

            Console.WriteLine("Thread 1 is exiting -------------");
        }



        static void Test2(object max)
        {

            for (int i = 1; i <= (int)max; i++)
            {
                Console.WriteLine("Test1: " + i);
            }

            Console.WriteLine("Thread 1 is exiting -------------");
        }
    }
}
