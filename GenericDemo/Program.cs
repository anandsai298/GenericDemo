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

            //GenericMethod genericMethod = new GenericMethod();
            //genericMethod.Print<int>(intArr);
            //genericMethod.Print<double>(doubleArr);
            //genericMethod.Print<char>(charArr);
            //genericMethod.Print<float>(Float);

            Console.WriteLine("with generic method Max Value:");
            GenericMethod <int>genericInt = new GenericMethod<int>(10,20,50);
            genericInt.FindMax();
            GenericMethod<float> genericFloat = new GenericMethod<float>(10.25f, 20.54f, 50.55f);
            genericFloat.FindMax();
            GenericMethod<string> genericString = new GenericMethod<string>("ask","sai","anand");
            genericString.FindMax();

            Console.WriteLine("without generic method Max Value:");
            Max_Int_Float_String max= new Max_Int_Float_String();
            max.MaxIntValue(10,20,30);
            max.MaxFloatValue(10.5f,24.6f,25.0f);
            max.MaxStringValue("ask","sai","anand");
        }
    }
}
