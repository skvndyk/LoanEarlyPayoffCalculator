using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEarlyPayoffCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loan 1 Name?");
            var name1 = Console.ReadLine();

            Console.WriteLine("Principal Remaining?");
            var prRemain1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Interest Rate?");
            var interestRate1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Monthly Payment?");
            var monthlyPayment1 = decimal.Parse(Console.ReadLine());

            var loan1 = new Loan(name1, prRemain1, interestRate1, monthlyPayment1);
        }

        public decimal PrintAmoritizationSchedule(Loan loan)
        {
            throw new NotImplementedException();
        }
    }
}
