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
            //TODO: Requerimiento 01 :  Al realizar una transferencia, la cuenta no se puede quedar nunca con menos de $ 200:
            if (Amount - amount > 200)
            {
                transferTo.AddMoney(amount);
                Amount -= amount;
            }
        }
        private void AddMoney(decimal amount)
        {
            Amount = Amount + amount;
        }
    }
}