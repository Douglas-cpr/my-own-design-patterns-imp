namespace Adaper.Services;

public interface IServiceHandler
{
  void Deposit();
}

public class ServiceHandler : IServiceHandler
{
  private readonly IService _service;

  public ServiceHandler(IService service)
  {
    _service = service;
  } 

  public void Deposit()
  {
    _service.DepositMoney();
  }
}