////using System;
////using System.Collections;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using System.Collections.ObjectModel;

////using ByteCollection1 = System.Collections.ObjectModel.Collection<byte>;



////namespace QuizTests
////{
////    interface Popo
////    {
////        void Kiki();
////    }
////    internal sealed class Some<T>
////    {

////    }
////    public class Foo
////    {
////        private int[] a = new int[10];
////        private Dictionary<string, int> b;
////        private int[] c = new int[100];

////        public int this[int i]
////        {
////            get { return a[i]; }
////            set { a[i] = value; }
////        }

////        public int this[string id]
////        {
////            get { return b[id]; }
////            set { b[id] = value; }
////        }

////        public int this[int i, int j]
////        {
////            get { return c[i * 10 + j]; }
////            set { c[i * 10 + j] = value; }
////        }
////    }


////    class Program
////    {
////        static IEnumerable<string> Get()
////        {
////            yield
////                return "1";
////            Console.WriteLine("2");
////            yield
////                return "3";
////        }

////        public static void Method(ref int x, out int y)
////        {
////            y = 7;
////            x = 6;
////        }
////        static void Main(string[] args)
////        {
////            int x = 5;
////            Method(ref x, out x);
////            Console.WriteLine(x);



////            Type t1 = typeof(System.Int32);
////            Type t2 = Type.GetType("System.Int32");
////            Type t3 = Type.GetType(System.Int32);
////            Type t4 = System.Int32.GetType();

////            int x = 5;
////            int y = 8;
////            if (x == 5) && ((y == 8) && !(x == y))
////                { }

////            Decimal x = Decimal.MaxValue;

////            unchecked
////            {
////                x++;
////            }

////            if (x == Decimal.MinValue)
////            {
////                Console.WriteLine("MinValue");
////            }
////            else if (x == Decimal.MaxValue)
////            {
////                Console.WriteLine("MaxValue");
////            }
////            else
////            {
////                Console.WriteLine("po");
////            }
////            Console.ReadLine();
////        }

////        class Name
////        {
////            public string A
////            {
////                private set;
////                get;
////            }

////            private string B
////            {
////                public set;
////                public get;
////            }

////            private string x;
////            public string C
////            {
////                get { return x.ToString(); }
////            }

////            public string D
////            {
////                set { x = value; }
////                private get;
////            }
////        }

////        public class Foo
////        {
////            private int a;
////            private int c;

////            public int A
////            {
////                get { return a; }
////                set { a = value; }
////            }

////            public int B
////            {
////                get { return 0; }
////            }


////            public int C
////            {
////                set { c = value; }
////            }

////            protected int D { get; set; }
////            protected int E { get; private set; }
////            protected int F { public get; set; }

////        }

////        class A
////        {
////            class B : A
////            { }
////        }
////    }
////}
