using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class NormalDemo
    {
        //without generic
        //method overloading same method name with diff parameters
        public void print(int[] arr)
        {
            foreach(var data in arr) 
            { 
            Console.WriteLine(data);
            }
        }
        public void print(double[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        public void print(char[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
