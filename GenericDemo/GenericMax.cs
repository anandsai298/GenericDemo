using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class GenericMax<T> where T : IComparable//generic Class
    {
        public T a, b, c;
        //constructor
        public GenericMax(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void FindMax()
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine(a + " is max value");
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine(b + " is max value");
            else
                Console.WriteLine(c + "is max value");
        }
    }
}
