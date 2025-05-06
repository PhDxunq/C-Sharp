using System;

class Program
{
    public static void Main(string[] args) {

        //Bai 1
        string name;
        int age;
        double grade;
        bool isStudent;

        //Bai2 
        const double pi = 3.14159;
        int r = 5;
        double dienTich = pi * r * r;
        Console.WriteLine("Dien tich: " + dienTich);

        //Bai3
        Console.Write("Nhap ten cua ban la : " );
        string inputName = Console.ReadLine() ?? "";
        Console.Write("Enter DOB: ");
        int year = int.Parse(Console.ReadLine() ?? "2000") ;
        DateTime currentYear = DateTime.Now;
        Console.WriteLine($"Name : {inputName} , DOB : {currentYear.Year - year}");

        //Bai4
        int a = 3;
        int b = 4;
        Console.WriteLine($"Tong : {a + b}");
        Console.WriteLine($"Hieu : {a - b}");
        Console.WriteLine($"Tich : {a * b}");
        Console.WriteLine($"Thuong : {(double)a / b}");
        Console.WriteLine($"Lay Du : {a % b}");

        //Bai5:
        Console.Write("Nhap vao 1 so nguyen: ");
        int number = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"{(number % 2 == 0 ? "So chan" : "So le")}");
    }
}