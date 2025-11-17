using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("محاسبه حاصل‌ضرب دو عدد با استفاده از تابع بازگشتی");
        Console.WriteLine("-----------------------------------------------");

        int a = ReadInt("عدد اول (a) را وارد کنید: ");
        int b = ReadInt("عدد دوم (b) را وارد کنید: ");

        int result = MultiplyRecursive(a, b);

        Console.WriteLine($"حاصل‌ضرب {a} × {b} = {result}");
    }

    // تابع بازگشتی برای ضرب
    static int MultiplyRecursive(int a, int b)
    {
        // حالت پایه
        if (b == 0)
            return 0;

        if (b > 0)
            return a + MultiplyRecursive(a, b - 1);

        // اگر b منفی باشد
        return -MultiplyRecursive(a, -b);
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value))
                return value;

            Console.WriteLine("ورودی نامعتبر است. یک عدد صحیح وارد کنید.");
        }
    }

