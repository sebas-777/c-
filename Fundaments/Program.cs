// See https://aka.ms/new-console-template for more information

namespace MyNamespace
{
    class Program 
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1+ num2;
            Console.WriteLine("La suma de " + num1 +" mas "+ num2 + " da como resultado : " + sum);
            

            double d1 = 0.5;
            double d2 = 0.5;
            double sum1 = d1 + d2 + num1;
            Console.WriteLine("La suma de  " + d1 + " mas " + d2 + " mas " + num1 + " da como resultado " + sum1);
            Console.Read();
        }
    }   
}