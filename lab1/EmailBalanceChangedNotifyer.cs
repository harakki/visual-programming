using System.Reflection;

namespace lab1;

public class EmailBalanceChangedNotifyer : INotifyer
{
    private readonly string _email;

    public EmailBalanceChangedNotifyer(string email)
    {
        _email = email;
    }

    public void Notify(decimal balance)
    {
        var method = MethodBase.GetCurrentMethod();
        var declaringType = method?.DeclaringType;

        Console.WriteLine($"{declaringType?.Name}\n{balance}");
    }
}