using System.Reflection;

namespace Homework_1_Class_diagrams;

public class SmsLowBalanceNotifyer : INotifyer
{
    private readonly decimal _lowBalanceValue;
    private readonly string _phone;

    public SmsLowBalanceNotifyer(string phone, decimal lowBalanceValue)
    {
        _phone = phone;
        _lowBalanceValue = lowBalanceValue;
    }

    public void Notify(decimal balance)
    {
        var method = MethodBase.GetCurrentMethod();
        var declaringType = method?.DeclaringType;

        if (balance < _lowBalanceValue) Console.WriteLine($"{declaringType?.Name}");

        Console.WriteLine(balance);
    }
}