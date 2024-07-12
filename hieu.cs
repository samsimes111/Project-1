using System;

namespace Hieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("So thu nhat: ");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.Write("So thu hai: ");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            int Hieu = number1 - number2;

            Console.WriteLine($"Ket qua cua {number1} va {number2} la: {Hieu}");
        }
    }
}


