using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so thu nhat:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap so thu hai:");
        int b = int.Parse(Console.ReadLine());

        int result = Multiply(a, b);
        Console.WriteLine("Tich cua {0} va {1} la: {2}", a, b, result);
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }
}