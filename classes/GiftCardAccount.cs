using System;
namespace classes{
    public class GiftCardAccount : BankAccount{
        private decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string name, decimal InitialBalance, decimal monthlyDeposit) : base(name, InitialBalance)
            => _monthlyDeposit = monthlyDeposit;
        public override void PerformMonthEndTransactions(){
            MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
        }
    }
}