using System.Reflection;

namespace Homework_1_Class_diagrams;

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