using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEarlyPayoffCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Loan 1 Name?");
            var name1 = Console.ReadLine();

            Console.WriteLine("Principal Remaining?");
            var initprRemain1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Interest Rate?");
            var interestRate1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Monthly Payment?");
            var monthlyPayment1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Additional One-Time Payment?");
            var oneTimePayment1 = decimal.Parse(Console.ReadLine());

            var loan1 = new Loan(name1, initprRemain1, interestRate1, monthlyPayment1, oneTimePayment1);

            PrintAmoritizationSchedule(loan1);
        }

        public static void PrintAmoritizationSchedule(Loan loan)
        {
            loan.AmoritizeThis();
            Console.ReadLine();
        }
    }
}
