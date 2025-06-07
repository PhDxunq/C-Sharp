using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class SavingsAccount
    {
        private double savingsBalance;
        private static double annualInterestRate;

        public SavingsAccount(double initialBalance)
        {
            savingsBalance = initialBalance;
        }

        public double CalculateMonthlyInterest()
        {
            double interest = savingsBalance * (annualInterestRate / 12);
            savingsBalance += interest;
            return interest;
        }

        public static void ModifyInterestRate(double newRate)
        {
            annualInterestRate = newRate;
        }

        public double Balance => savingsBalance;
    }
}
