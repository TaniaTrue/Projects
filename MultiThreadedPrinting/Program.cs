using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadedPrinting
{
    public class Printer
    {
        private object threadlock = new object();
        public void PrintNumbers()
        {
            lock (threadlock)
            {
                Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
                Console.WriteLine("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(2));
                    Console.Write("{0}, ", i);
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***Synchronizing threads***");
            //Printer p = new Printer();
            //Thread[] threads = new Thread[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
            //    threads[i].Name = string.Format("Worker thread #{0}", i);
            //}
            //foreach (Thread t in threads )
            //{
            //    t.Start();
            //}

           
            Console.ReadLine();
        }
    }
}
