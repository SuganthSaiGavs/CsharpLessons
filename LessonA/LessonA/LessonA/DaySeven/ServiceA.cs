using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySeven
{
    internal class ServiceA
    {
        int x = 0; //Global variables are not thread safe.
        public void DoTaskA()
        {
            Monitor.Enter(this);  // Thread Lock
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Inside DoTaskA");
            Console.WriteLine("\t Thread ID:" + id);
            //int x = 0;
            try
            {
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tID=" + id + ":X=" + x + "icount=" + icount);
                    Thread.Sleep(15000);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }

        public static void DemoA()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }


        public static void DemoB() //Multiple Threads
        {
            //Thread t1 = new Thread(); This is illegal, you can pass only delegate methods inside params.
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            Thread t2 = new Thread(a1.DoTaskA); //delegate
            t2.Start();         //lock                         
            Console.WriteLine("-----------End Of DoTask(1)-----------------");

            a1.DoTaskA();
            Console.WriteLine("-----------End Of DoTask(2)-----------------");

            Console.WriteLine("-----------End Of DemoB-----------------");
        }

        public static void DemoB2() //Multiple Threads
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA); //delegate
            Console.WriteLine(t1.ManagedThreadId + "T1 State" + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + "State After Start" + t1.ThreadState);
            Thread.Sleep(6000);
            Console.WriteLine(t1.ManagedThreadId + "T1 State After Sleep" + t1.ThreadState);
            Console.WriteLine("------------End Of DemoB--------------");
        }

        public static void DemoC() //Multiple Threads
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            Console.WriteLine("-------------End of DemoC---------------");
        }

        public static void DemoD() //Multiple Threads
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(7000);
       //   if(t1.IsAlive) t1.Abort();  //Thread.Abort is obsolete
            t2.Join(7000);
       //   if (t2.IsAlive) t2.Abort();  //Thread.Abort is obsolete
            Console.WriteLine("-------------End of DemoC---------------");

        }


    }
}
