using Factory.Apis;

namespace Factory.Factories;

public abstract class ApiFactory 
{
  public abstract IApi CreateApi();

  public string GetOperation() 
  {
    var api = CreateApi();
    api.OpenConnection();
    var response = api.Get();
    api.CloseConnection();
    return response;
  }
}

public class WebApiFactory : ApiFactory
{
  public override IApi CreateApi()
  {
    return new ApiWeb();
  }
}

public class SoapApiFactory : ApiFactory
{
  public override IApi CreateApi()
  {
    return new ApiSoap();
  }
}