using Adaper.Services;
using Adapter.Adapters;

namespace Adapter;


public static class Main
{
  public static void SimpleTest(string[] args)
  {
    var handler1 = new ServiceHandler(new BankService());

    handler1.Deposit();

    var adapter = new AirportServiceAdapter(new AiportService());
    var adaptedHandler = new ServiceHandler(adapter);    
  }
}