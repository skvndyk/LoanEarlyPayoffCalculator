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
        public string Name { get; set; }
        public decimal PrincipalRemaining { get; set; }
        //public decimal InitialPrincipal { get; set; }
        public decimal InterestRate { get; set; }
        public decimal MonthlyPayment { get; set; }
        private decimal InterestMultiplier => InterestRate / 12;
        
        public decimal CalculateBalanceAfterPayment()
        {
            var interest = CalculateInterest();
            var newBalance = PrincipalRemaining - (MonthlyPayment - interest);
            return newBalance;
        }
        public decimal CalculateInterest() { return InterestMultiplier * PrincipalRemaining; }

    }
}
