using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenericMethod
    {
        public void Print<T>(T[] arr)
        {
            foreach(var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        //Generic method
        public void FindMax<T>(T a, T b,T c) where T : IComparable//Icomparable is inbuilt to have the compareto method
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine(a + " is max string value");
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine(b + " is max string value");
            else
                Console.WriteLine(c + "is max string value");
        }
    }
}
