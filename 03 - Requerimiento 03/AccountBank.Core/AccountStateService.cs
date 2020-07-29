namespace AccountUnitTest.Core
{
    public class AccountStateService
    {
        public bool IsEnableToTransfer(Account account) =>
            (account.Amount > 0 ||
            (account.Amount <= 0 && account.Enable)) ?
                true :
                false;
    }
}
