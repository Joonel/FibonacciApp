using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість чисел Фібоначі для обчислення:");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}
