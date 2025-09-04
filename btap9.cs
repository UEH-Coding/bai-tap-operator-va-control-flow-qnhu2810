using System;

class Program
{
    static void Main(string[] args)
    {
        // Bài 1: Thực hiện phép toán với 2 số
        Console.WriteLine("=== Bài 1: Phép toán hai số ===");
        Console.Write("Nhập số thứ nhất: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập phép toán (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double result = 0;
        switch (op)
        {
            case '+': result = num1 + num2; break;
            case '-': result = num1 - num2; break;
            case '*': result = num1 * num2; break;
            case '/': result = (num2 != 0) ? num1 / num2 : double.NaN; break;
            default: Console.WriteLine("Phép toán không hợp lệ."); break;
        }
        Console.WriteLine("Kết quả: " + result);

        // Bài 2: Tính giá trị hàm số
        Console.WriteLine("\n=== Bài 2: Giá trị hàm số x = y^2 + 2y + 1 ===");
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }

        // Bài 3: Tính vận tốc
        Console.WriteLine("\n=== Bài 3: Tính vận tốc ===");
        Console.Write("Nhập quãng đường (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập giờ: ");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập phút: ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập giây: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        double timeHours = hours + minutes / 60.0 + seconds / 3600.0;
        double speedKmH = distance / timeHours;
        double speedMilesH = speedKmH * 0.621371; // 1 km = 0.621371 miles

        Console.WriteLine($"Tốc độ: {speedKmH:F2} km/h = {speedMilesH:F2} miles/h");

        // Bài 4: Tính thể tích và diện tích mặt cầu
        Console.WriteLine("\n=== Bài 4: Hình cầu ===");
        Console.Write("Nhập bán kính r: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Diện tích mặt cầu: {surface:F2}");
        Console.WriteLine($"Thể tích khối cầu: {volume:F2}");

        // Bài 5: Kiểm tra ký tự
        Console.WriteLine("\n=== Bài 5: Kiểm tra ký tự ===");
        Console.Write("Nhập một ký tự: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if ("aeiouAEIOU".IndexOf(ch) >= 0)
            Console.WriteLine("Đây là nguyên âm.");
        else if (char.IsDigit(ch))
            Console.WriteLine("Đây là chữ số.");
        else if (char.IsLetter(ch))
            Console.WriteLine("Đây là phụ âm.");
        else
            Console.WriteLine("Đây là ký tự đặc biệt.");
    }
}