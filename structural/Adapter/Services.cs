namespace Adaper.Services;

public interface IService 
{
  void DepositMoney();
}

public class BankService : IService
{
  public void DepositMoney(){ }
}

public class AiportService
{
  public void DepositCash() {}
}