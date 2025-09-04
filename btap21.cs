using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int choice;
        do
        {
            Console.WriteLine("\n=== MENU CHƯƠNG TRÌNH ===");
            Console.WriteLine("1. Kiểm tra số chẵn hay lẻ");
            Console.WriteLine("2. Tìm số lớn nhất trong 3 số");
            Console.WriteLine("3. Xác định tọa độ thuộc góc phần tư nào");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");

            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    KiemTraChanLe();
                    break;
                case 2:
                    TimSoLonNhat();
                    break;
                case 3:
                    KiemTraToaDo();
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình...");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                    break;
            }

        } while (choice != 0);
    }

    // Bài 1: Kiểm tra chẵn lẻ
    static void KiemTraChanLe()
    {
        Console.Write("Nhập một số: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine($"{n} là số chẵn.");
        else
            Console.WriteLine($"{n} là số lẻ.");
    }

    // Bài 2: Tìm số lớn nhất
    static void TimSoLonNhat()
    {
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ ba: ");
        int c = int.Parse(Console.ReadLine());

        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        Console.WriteLine($"Số lớn nhất là: {max}");
    }

    // Bài 3: Kiểm tra tọa độ
    static void KiemTraToaDo()
    {
        Console.Write("Nhập tọa độ X: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Nhập tọa độ Y: ");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
            Console.WriteLine($"Điểm ({x},{y}) nằm ở góc phần tư thứ 1.");
        else if (x < 0 && y > 0)
            Console.WriteLine($"Điểm ({x},{y}) nằm ở góc phần tư thứ 2.");
        else if (x < 0 && y < 0)
            Console.WriteLine($"Điểm ({x},{y}) nằm ở góc phần tư thứ 3.");
        else if (x > 0 && y < 0)
            Console.WriteLine($"Điểm ({x},{y}) nằm ở góc phần tư thứ 4.");
        else if (x == 0 && y == 0)
            Console.WriteLine("Điểm nằm ở gốc tọa độ (0,0).");
        else if (x == 0)
            Console.WriteLine($"Điểm ({x},{y}) nằm trên trục Y.");
        else if (y == 0)
            Console.WriteLine($"Điểm ({x},{y}) nằm trên trục X.");
    }
}