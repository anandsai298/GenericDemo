// See https://aka.ms/new-console-template for more information
using System;
namespace GenericDemo
{
    class program
    {
        static void Main(String[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArr = { 'a', 'b', 'c', 'd' };
            Console.WriteLine("without generic method");
            NormalDemo normalDemo = new NormalDemo();
            normalDemo.print(intArr);
            normalDemo.print(doubleArr);
            normalDemo.print(charArr);

            Console.WriteLine("with generic method");
            GenericMethod genericMethod = new GenericMethod();
            genericMethod.Print<int>(intArr);
            genericMethod.Print<double>(doubleArr);
            genericMethod.Print<char>(charArr);
        }
    }
}
