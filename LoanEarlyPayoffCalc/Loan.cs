using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEarlyPayoffCalc
{
    public class Loan
    {
        public Loan(string name, decimal initialPrincipalRemaining, decimal interestRate,
            decimal monthlyPayment, decimal oneTimePayment)
        {
            Name = name;
            InitialPrincipalRemaining = initialPrincipalRemaining;
            InterestRate = interestRate;
            MonthlyPayment = monthlyPayment;
            OneTimePayment = oneTimePayment;
        }

        public int PaymentsApplied = 0;
        public string Name { get; set; }
        public decimal InitialPrincipalRemaining { get; set; }
        public decimal PrincipalRemaining { get; set; }
        //public decimal InitialPrincipal { get; set; }
        public decimal InterestRate { get; set; }
        public decimal TotalInterestPaid = 0;
        public decimal MonthlyPayment { get; set; }
        public decimal OneTimePayment { get; set; }
        private decimal InterestMultiplier => InterestRate / 12;
        public DateTime CurrentDT => DateTime.Now;
        public DateTime CalcDT => CurrentDT.AddMonths(PaymentsApplied);
        
        private decimal CalculateBalanceAfterPayment()
        {
            PaymentsApplied++;
            var interest = CalculateInterest();
            TotalInterestPaid += interest;
            var newBalance = PrincipalRemaining - (MonthlyPayment - interest);
            return newBalance;
        }
        private decimal CalculateInterest() { return InterestMultiplier * PrincipalRemaining; }

        public void AmoritizeThis()
        {
            PrincipalRemaining = InitialPrincipalRemaining;
            while (PrincipalRemaining - MonthlyPayment > 0)
            {
                var balanceAfterPayment = CalculateBalanceAfterPayment();
                Console.WriteLine($"{CalcDT.ToString("MM/yy")}\t{balanceAfterPayment.ToString("C")}");
                PrincipalRemaining = balanceAfterPayment;
            }
        }

    }
}
