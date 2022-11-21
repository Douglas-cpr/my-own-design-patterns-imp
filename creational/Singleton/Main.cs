namespace Singleton;

public class BankAccount 
{
  private static BankAccount _instance;
  private static readonly object _lock = new object();

  private void constructor()
  {
    _instance = new BankAccount();
  }

  public static BankAccount GetInstance()
  {
    if (_instance is null)
    {
      lock(_lock) // block other threads
      {
        _instance = new BankAccount();
      }
    }

    return _instance;
  }
}


public class Main
{
  public void App()
  {
    var account = BankAccount.GetInstance(); 
    var cachedAccount = BankAccount.GetInstance();
  }
}