using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("محاسبه محیط، نیم‌محیط و مساحت مثلث با فرمول هرون");
        Console.WriteLine("-------------------------------------------------");

        double a = ReadPositiveDouble("ضلع a را وارد کنید: ");
        double b = ReadPositiveDouble("ضلع b را وارد کنید: ");
        double c = ReadPositiveDouble("ضلع c را وارد کنید: ");

        // بررسی نابرابری مثلث: هر ضلع باید از جمع دو ضلع دیگر کمتر باشد
        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("خطا: این سه مقدار نمی‌توانند اضلاع یک مثلث باشند (نابرابری مثلث برقرار نیست).");
            return;
        }

        double perimeter = a + b + c;
        double s = perimeter / 2.0; // نیم‌محیط
        double areaSquared = s * (s - a) * (s - b) * (s - c);

        // به‌خاطر خطاهای گرد کردن ممکن است مقدار خیلی کوچک منفی شود
        if (areaSquared < 0) areaSquared = 0;

        double area = Math.Sqrt(areaSquared);

        Console.WriteLine();
        Console.WriteLine($"محیط مثلث: {perimeter}");
        Console.WriteLine($"نیم‌محیط (s): {s}");
        Console.WriteLine($"مساحت مثلث (هرون): {area}");
    }

    static double ReadPositiveDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double value) && value > 0)
                return value;

            Console.WriteLine("ورودی نامعتبر است. یک عدد مثبت وارد کنید.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
  
