namespace Homework_1_Class_diagrams;

public class Account
{
    private readonly List<INotifyer> _notifyers;

    public Account()
    {
        Balance = 0;
        _notifyers = new List<INotifyer>();
    }

    public Account(decimal balance)
    {
        Balance = balance;
        _notifyers = new List<INotifyer>();
    }

    public decimal Balance { get; private set; }

    public void AddNotifyer(INotifyer notifyer)
    {
        _notifyers.Add(notifyer);
    }

    public void ChangeBalance(decimal value)
    {
        Balance = value;
        Notification();
    }

    private void Notification()
    {
        foreach (var notice in _notifyers) notice.Notify(Balance);
    }
}