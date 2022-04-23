using System;

namespace lab3ass
{
    class Program
    {
        static void Main(string[] args)
        {
             int number;
            Console.Write("Input a number:");
            number = Convert.ToInt32(Console.ReadLine());

           switch(number)
           {
               case 17:
               Console.WriteLine("Prime number");
               break;

               case 57:
               Console.WriteLine("Not prime number");
               break;
           }
        }
    }
}
