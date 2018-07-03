using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMultiThreadApp2
{
    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine("-> {0} Is executing PrintNumbers()", Thread.CurrentThread.Name);
            Console.WriteLine("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}, ",i);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***The amazing thread app***");
            Console.Write("Do you want [1] or [2] threads? ");
            string threadCount = Console.ReadLine();
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            Console.WriteLine("-> {0} is executing main()", Thread.CurrentThread.Name);
            Printer p = new Printer();
            switch (threadCount)
            {
                case "2":
                    //Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    Thread backgroundThread = new Thread(p.PrintNumbers);
                    backgroundThread.Name = "Secondary";
                    backgroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I don't know what do you want...you get 1 thread.");
                    goto case "1";
            }
            MessageBox.Show("I'm busy!", "Work on main thread...");
            Console.ReadLine();
        }
    }
}
