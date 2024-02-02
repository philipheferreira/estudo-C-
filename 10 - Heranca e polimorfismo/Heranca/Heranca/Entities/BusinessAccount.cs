

namespace Heranca.Entities{
    class BusinessAccount : Account{
        public double loanLimit { get; set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) {
            loanLimit = loanLimit;
        }

        public void Loan(double amount){ 
            if (amount <= loanLimit){
                Balance += amount;
            }
        }

    }
}
