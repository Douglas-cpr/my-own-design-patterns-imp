namespace Adapter;

public struct JSON {}

public struct XML {}

public class BankService
{
  private readonly XML _data;

  public BankService(XML data)
  {
    _data = data;
  }
}

public class GovernmentService
{
  private readonly JSON _data;

  public GovernmentService(JSON data)
  {
    _data = data;
  }
}

public class ApplicationService
{
  public XML GetData()
  {
    return new XML();
  }
}

public class GovernmentAdapter
{
  private readonly JSON _data;

  public GovernmentAdapter(ApplicationService app)
  {
    app.GetData();
    _data = new JSON();
  }
  
  public JSON GetData()
  {
    return _data;
  }
}

public static class Main
{
  public static void SimpleTest(string[] args)
  {
    var app = new ApplicationService();

    var adapter = new GovernmentAdapter(app);

    var govService = new GovernmentService(adapter.GetData());
    var bankService = new BankService(app.GetData());

  }
}