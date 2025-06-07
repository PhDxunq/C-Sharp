// See https://aka.ms/new-console-template for more information
using Lesson8;

Rectangle rect1 = new Rectangle();

// Question1
rect1.Length = 10.5;
rect1.Width = 5.2;
Console.WriteLine($"Perimeter: {rect1.GetPerimeter()}, Area: {rect1.GetArea()}");

rect1.Length = 25.0; 
rect1.Width = -4.0;  
Console.WriteLine($"Perimeter: {rect1.GetPerimeter()}, Area: {rect1.GetArea()}");

//Question2

SavingsAccount saver1 = new SavingsAccount(2000.0);
SavingsAccount saver2 = new SavingsAccount(3000.0);

SavingsAccount.ModifyInterestRate(0.04); // 4%

Console.WriteLine("Interest at 4% annual rate:");
for (int i = 1; i <= 12; i++)
{
    double interest1 = saver1.CalculateMonthlyInterest();
    double interest2 = saver2.CalculateMonthlyInterest();

    Console.WriteLine($"Month {i}: Saver1 Balance: {saver1.Balance:F2}, Saver2 Balance: {saver2.Balance:F2}");
}

SavingsAccount.ModifyInterestRate(0.05); // 5%

Console.WriteLine("\nInterest at 5% annual rate (next month):");
double interest1New = saver1.CalculateMonthlyInterest();
double interest2New = saver2.CalculateMonthlyInterest();
Console.WriteLine($"Saver1 Balance: {saver1.Balance:F2}, Saver2 Balance: {saver2.Balance:F2}");

