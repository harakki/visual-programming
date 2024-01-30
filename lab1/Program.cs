namespace lab1;

internal static class Program
{
    private static void Main(string[] args)
    {
        var catBankAccount = new Account(100);

        INotifyer newEmailSubscription = new EmailBalanceChangedNotifyer("not-a-cat@bark.com");
        INotifyer newSmsSubscription = new SmsLowBalanceNotifyer("555-0134", 50);

        catBankAccount.AddNotifyer(newEmailSubscription);
        catBankAccount.AddNotifyer(newSmsSubscription);

        /* Fish Toys. Покупка на сумму 59 Cat. 30 января 2024, 21:27 */
        catBankAccount.ChangeBalance(41);
    }
}