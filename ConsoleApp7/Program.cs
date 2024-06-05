using System;

class Program
{
    public static void Main(string[] args)
    {
        //1 задание 
        Console.WriteLine("n ?");
        int n = int.Parse(Console.ReadLine());
        Random random = new Random();
        int[] a = new int[n];
        int[] b = new int[n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            a[i] = random.Next(-10, 10);
            b[i] = random.Next(-10, 10);

            count += a[i] * b[i];
        }
        Console.WriteLine("Massive a");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);

        }
        Console.WriteLine("Massive b");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(b[i]);

        }
        Console.WriteLine("Count");
        Console.WriteLine(count);

        //2 задание
        int Count = 0;
        int[] mass = new int[10];
        Console.WriteLine("Next ");
        for (int i = 0; i < 10; i++)
        {
            mass[i] = random.Next(0, 10);

        }
        Console.WriteLine("Massive");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(mass[i]);
        }
        for (int i = 1; i < 9; i++)
        {
            if (mass[i - 1] < mass[i] & mass[i + 1] < mass[i])
            {
                Count += 1;

            }
        }
        Console.WriteLine("COunt");
        Console.WriteLine(Count);
    }



}