using Composite.Components;

namespace Composite.Clients;

public class Client
{
  public Client() {}

  public void ClientCode(Component leaf)
  {
    Console.WriteLine($"Result: {leaf.Operation()}");
  }

  public void ClientCode2(Component component1, Component component2)
  {
    if (component1.IsComposite()) component1.Add(component2);
    Console.WriteLine($"Result: {component1.Operation()}");
  }
}