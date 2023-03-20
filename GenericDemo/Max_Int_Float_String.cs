using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Max_Int_Float_String
    {
        public void MaxIntValue(int a, int b,int c)
        {
            if (a > b && a > c)
                Console.WriteLine(a + " is max int value");
            if (b > a && b > c)
                Console.WriteLine(b + " is max int value");
            else
                Console.WriteLine(c + "is max int value");
        }
        public void MaxFloatValue(float a, float b, float c)
        {
            if (a > b && a > c)
                Console.WriteLine(a + " is max float value");
            if (b > a && b > c)
                Console.WriteLine(b + " is max float value");
            else
                Console.WriteLine(c + "is max float value");
        }
        public void MaxStringValue(string a, string b, string c)
        {
            if (a.CompareTo(b)>0 && a.CompareTo(c)>0)
                Console.WriteLine(a + " is max string value");
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine(b + " is max string value");
            else
                Console.WriteLine(c + "is max string value");
        }
    }
}
