﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_UpcastingDowncasting.Entities{
    internal class BusinessAccount : Account{
        public double LoanLimit { get; set; }

        public BusinessAccount(){}

        public BusinessAccount(int number, string holder, double balance, double loanLimit): base(number, holder, balance){
            LoanLimit = loanLimit;
        }

        public void Loan(double value){
            if (value < LoanLimit){
                Balance = value;
            }
        }
    }
}
