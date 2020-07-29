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

            if (Amount - amount > 200
                &&
            //TODO: Requerimiento 02 :  Para poder realizar una transferencia la cuenta destino debe de estar habilitada.
                transferTo.Enable)
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