using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEarlyPayoffCalc
{
    public class Loan
    {
        public Loan(string name, decimal principalRemaining, decimal interestRate,
            decimal monthlyPayment)
        {
            Name = name;
            PrincipalRemaining = principalRemaining;
            InterestRate = interestRate;
            MonthlyPayment = monthlyPayment;
        }

        private int PaymentsApplied = 0;
        public string Name { get; set; }
        public decimal PrincipalRemaining { get; set; }
        //public decimal InitialPrincipal { get; set; }
        public decimal InterestRate { get; set; }
        public decimal MonthlyPayment { get; set; }
        private decimal InterestMultiplier => InterestRate / 12;
        public DateTime CurrentDT => DateTime.Now;
        public DateTime CalcDT => CurrentDT.AddMonths(PaymentsApplied);
        
        public decimal CalculateBalanceAfterPayment()
        {
            PaymentsApplied++;
            var interest = CalculateInterest();
            var newBalance = PrincipalRemaining - (MonthlyPayment - interest);
            return newBalance;
        }
        public decimal CalculateInterest() { return InterestMultiplier * PrincipalRemaining; }

    }
}
