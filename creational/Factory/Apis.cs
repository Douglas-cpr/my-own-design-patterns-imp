using System;

namespace Factory.Apis;

public interface IApi
{
  void OpenConnection();
  string Get();
  void CloseConnection();
}

public class ApiWeb : IApi
{
  public void CloseConnection()
  {
    Console.WriteLine("Connection HTTP closed");
  }

  public string Get()
  {
    Console.WriteLine("Send HTTP get request");
    return "success json";
  }

  public void OpenConnection()
  {
    Console.WriteLine("Close request");
  }
}

public class ApiSoap : IApi
{
  public void CloseConnection()
  {
    Console.WriteLine("Connection SOAP closed");
  }

  public string Get()
  {
     Console.WriteLine("Call RPC method");
    return "success xml";
  }

  public void OpenConnection()
  {
    Console.WriteLine("Close SOAP");
  }
}