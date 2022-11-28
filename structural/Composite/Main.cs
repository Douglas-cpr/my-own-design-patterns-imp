using Composite.Clients;
using Composite.Components;

namespace Composite;

public static class Application
{
  public static void Main(string[] args)
  {
    var client = new Client();
    

    // ===
    Console.WriteLine("Client - Getting simple component");
    var leaf = new Leaf();
    client.ClientCode(leaf);
    // ===

    // ===
    Console.WriteLine("Client - Getting complex component");
    var tree = new Complex();

    var branch1 = new Complex();
    branch1.Add(new Leaf());
    branch1.Add(new Leaf());

    var branch2 = new Complex();
    branch2.Add(new Leaf());

    tree.Add(branch1);
    tree.Add(branch2);

    client.ClientCode(tree);
    // ===

    // ===
    Console.WriteLine("Client - Don't check complex when managing");
    client.ClientCode2(tree, leaf);
    // ===
  }
}