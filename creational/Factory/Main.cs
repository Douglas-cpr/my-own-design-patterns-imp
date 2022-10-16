using System;
using Factory.Factories;

namespace Factory;

class Program 
{
  public static void Main(string[] args) 
  {
    var webApi = new WebApiFactory();
    var webApiResponse = webApi.GetOperation();
    Console.WriteLine($"WebApi: {webApiResponse}");

    var soapApi = new SoapApiFactory();
    var soapApiResonse = soapApi.GetOperation();
    Console.WriteLine($"SoapApi: {soapApiResonse}");
  }
}