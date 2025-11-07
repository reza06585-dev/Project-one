using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> n = new List<int>();
        Console.WriteLine("enter 5 numbers");

        for (int a = 1; a <= 5; a++)
        {
            Console.Write($"enter number {a}: ");
            int b = int.Parse(Console.ReadLine());

            if (b == 2)
            {
                n.Add(b);             }
        }

        if (n.Count == 0)
        {
            Console.WriteLine("No number = 2");
        }
        else
        {
            Console.WriteLine(n.Count + " numbers = 2");
            for (int i = 0; i < n.Count; i++)
            {
                Console.WriteLine($"number: {n[i]}");
            }
        }
