using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenericMethod<T> where T : IComparable//generic Class
    {
        public void Print<T>(T[] arr)
        {
            foreach(var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        //constructor
        public T a, b, c;
        public GenericMethod(T a, T b, T c)
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
