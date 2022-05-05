using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
    internal class Savings : Account {

        public decimal InterestRate { get; set; } = 0.12m;
        private decimal CalculateInterest(int months) {
            var interest = Balance * (InterestRate / 12) * months;
            return interest;
        }
        public void PayInterest(int months) {           //use void when not Returning anything
            var interest = CalculateInterest(months);
            Deposit(interest);
        }
        public Savings() { }
    }
}
