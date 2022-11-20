using Adaper.Services;

namespace Adapter.Adapters;

public class AirportServiceAdapter : IService
{
  private readonly AiportService _service;

  public AirportServiceAdapter(AiportService service)
  {
    _service = service;
  }

  public void DepositMoney()
  {
    _service.DepositCash();
  }
}