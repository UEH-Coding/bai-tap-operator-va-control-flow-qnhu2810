using System;

class Program
{
    static void Main(string[] args)
    {
        // Cho phép hiển thị tiếng Việt trong console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // === Bài 1: Kiểm tra loại tam giác ===
        Console.WriteLine("=== Bài 1: Tam giác ===");
        Console.Write("Nhập cạnh a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập cạnh c: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Tam giác đều.");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Tam giác cân.");
        else
            Console.WriteLine("Tam giác thường.");

        // === Bài 2: Đọc 10 số, tính tổng và trung bình ===
        Console.WriteLine("\n=== Bài 2: Tổng và trung bình ===");
        int[] numbers = new int[10];
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nhập số thứ {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        double avg = sum / 10.0;
        Console.WriteLine($"Tổng = {sum}, Trung bình = {avg}");

        // === Bài 3: Bảng nhân ===
        Console.WriteLine("\n=== Bài 3: Bảng nhân ===");
        Console.Write("Nhập một số: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }

        // === Bài 4: Hiển thị tam giác số ===
        Console.WriteLine("\n=== Bài 4: Tam giác số ===");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }

        // === Bài 5: Hiển thị pattern ===
        Console.WriteLine("\n=== Bài 5: Pattern ===");
        int k = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(k++ + " ");
            Console.WriteLine();
        }

        // === Bài 6: Chuỗi Harmonic ===
        Console.WriteLine("\n=== Bài 6: Dãy Harmonic ===");
        Console.Write("Nhập số n: ");
        int hn = int.Parse(Console.ReadLine());
        double hsum = 0;
        for (int i = 1; i <= hn; i++)
        {
            hsum += 1.0 / i;
            Console.Write("1/" + i + " ");
        }
        Console.WriteLine($"\nTổng = {hsum:F4}");

        // === Bài 7: Số hoàn hảo ===
        Console.WriteLine("\n=== Bài 7: Số hoàn hảo ===");
        Console.Write("Nhập khoảng bắt đầu: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Nhập khoảng kết thúc: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Các số hoàn hảo:");
        for (int i = start; i <= end; i++)
        {
            int s = 0;
            for (int j = 1; j < i; j++)
                if (i % j == 0) s += j;
            if (s == i && i != 0)
                Console.WriteLine(i);
        }

        // === Bài 8: Kiểm tra số nguyên tố ===
        Console.WriteLine("\n=== Bài 8: Số nguyên tố ===");
        Console.Write("Nhập một số: ");
        int p = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (p < 2) isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(p); i++)
            {
                if (p % i == 0) { isPrime = false; break; }
            }
        }
        Console.WriteLine(isPrime ? "Đây là số nguyên tố." : "Không phải số nguyên tố.");
    }
}