namespace AccountUnitTest.Core
{
    public class Account
    {
        public decimal Amount { get; set; }
        public AccountEnum Type { get; set; }
        public bool Enable { get; set; }
        public void Transfer(Account transferTo, decimal amount)
        {
            if (Type == AccountEnum.Special
                && (transferTo.Type == AccountEnum.Common
                    ||
                    transferTo.Type == AccountEnum.Special))
                TransferMoney(transferTo, amount);
            else if (Type == AccountEnum.Common
                     && (transferTo.Type == AccountEnum.Common))
                TransferMoney(transferTo, amount);
        }


        private void TransferMoney(Account transferTo, decimal amount)
        {
            transferTo.AddMoney(amount);
            Amount -= amount;
        }
        private void AddMoney(decimal amount)
        {
            Amount = Amount + amount;
        }
    }
}