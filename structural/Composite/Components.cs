using System;
using System.Text;

namespace Composite.Components;

public abstract class Component 
{
  public Component() {}

  public abstract string Operation();

  public virtual void Add(Component component)
  {
    throw new NotImplementedException();
  } 

  public virtual void Remove(Component component)
  {
    throw new NotImplementedException();
  }

  public virtual bool IsComposite()
  {
    return true;
  }
}

public class Leaf : Component
{
  public override string Operation()
  {
    return "This is a leaf";
  }

  public override bool IsComposite()
  {
    return false;
  } 
}

public class Complex : Component 
{
  protected List<Component> _children = new List<Component>();

  public override void Add(Component component)
  {
    _children.Add(component);
  }

  public override void Remove(Component component)
  {
    _children.Remove(component);
  }

  public override string Operation()
  {
    var j = 0;

    var result = new StringBuilder();

    result.Append("Branch(");
    foreach(var component in _children)
    {
      result.Append(component.Operation());

      if (j != _children.Count - 1)
      {
        result.Append("+");
      }
      j++;
    } 
    result.Append(")");
    
    return result.ToString();
  }
}
