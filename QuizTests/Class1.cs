using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuizTests
{
    class Class1
    {
        private static readonly object Lock1 = new object();
        private static readonly object Lock2 = new object();

        public static void Func1()
        {
            lock (Lock1)
            {
                Thread.Sleep(1000);
                lock(Lock2)
                    Console.WriteLine("ABC");
            }
        }

        public static void Func2()
        {
            lock (Lock2)
            {
                Thread.Sleep(1000);
                lock (Lock1)
                    Console.WriteLine("DEF");
            }
        }
        static void Main(string[] args)
        {



            //Console.Write("Begin");

            //var thr1 = new Thread(Func1);
            //var thr2 = new Thread(Func2);

            //thr1.Start();
            //thr2.Start();
            //Console.Write("End");

            Counter c1 = new Counter();
            c1.GetCount();

            Counter c2 = new Counter();
            Console.WriteLine( c2.GetCount());

            Console.ReadLine();
        }

        class Counter
        {
            public static int count = 0;

            public int GetCount()
            {
                return ++count;
            }
        }

    }
}


//var result = "";
//var arg1 = "short string";
//var arg2 = "long string";

//result = arg2.Length > arg2.Length
//    ? arg2[0] < arg1[0]
//    ? arg2[arg2.Length - 1] == arg1[arg1.Length - 1]
//    ? arg1
//    : arg2
//    : arg1.ToUpper()
//    : arg2.ToUpper(); LONG STRING




//------------------------------------------


//class FooA
//{
//    public void Method()
//    {
//        Console.WriteLine("A");
//    }
//}
//class FooB : FooA
//{
//    new void Method()
//    {
//        Console.WriteLine("B");
//    }
//}


//var fooB = new FooB();
//fooB.Method();

//------------------------------------------