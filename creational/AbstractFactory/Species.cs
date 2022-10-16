namespace AbstractFactory.Species;

public interface IArms 
{
  void HasHand();
  void TakeObject();
}

public interface ILegs 
{
  void HasFoot();
  void StandUp();
}

public class HumanArms : IArms
{
  public void HasHand()
  {
    Console.WriteLine("Human Hands");
  }

  public void TakeObject()
  {
    Console.WriteLine("[Human] Taking whatever object...");
  }
}

public class MonkeyArms : IArms
{
  public void HasHand() 
  {
    Console.WriteLine("Monkey Hands");
  }

  public void TakeObject() 
  {
    Console.WriteLine("[Monkey] Taking banana...");
  }
}

public class HumanLegs : ILegs
{
  public void HasFoot()
  {
    Console.WriteLine("Human Foots");
  }

  public void StandUp()
  {
    Console.WriteLine("[Human] Stand Up");
  }
}

public class MonkeyLegs : ILegs
{
  public void HasFoot()
  {
    Console.WriteLine("Money Foots");
  }

  public void StandUp()
  {
    Console.WriteLine("[Money] Stand Up");
  }
}