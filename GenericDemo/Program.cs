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
            float[] Float = { 1.5f, 2.5f, 3.5f };
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
            genericMethod.Print<float>(Float);

            Console.WriteLine("with generic method Max Value:");
            GenericMax<int>genericInt = new GenericMax<int>(10,20,50);
            genericInt.FindMax();
            GenericMax<float> genericFloat = new GenericMax<float>(10.25f, 20.54f, 50.55f);
            genericFloat.FindMax();
            GenericMax<string> genericString = new GenericMax<string>("ask","sai","anand");
            genericString.FindMax();

            Console.WriteLine("without generic method Max Value:");
            Max_Int_Float_String max= new Max_Int_Float_String();
            max.MaxIntValue(10,20,30);
            max.MaxFloatValue(10.5f,24.6f,25.0f);
            max.MaxStringValue("ask","sai","anand");
        }
    }
}
