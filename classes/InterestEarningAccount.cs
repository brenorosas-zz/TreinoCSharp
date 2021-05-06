using System;
namespace classes{
    public class InterestEarningAccount : BankAccount{
        public InterestEarningAccount(string name, decimal InitialBalance) : base(name, InitialBalance){

        }

        public override void PerformMonthEndTransactions(){
            if(Balance > 500m){
                var interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interst");
            }
        }
    }
}