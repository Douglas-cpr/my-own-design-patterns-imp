using AbstractFactory.Species;

namespace AbstractFactory.Factories;


public interface IBipedFactory
{
  IArms CreateArms();
  ILegs CreateLegs();
}

public class HumanFactory : IBipedFactory
{
  public IArms CreateArms()
  {
    return new HumanArms();
  }

  public ILegs CreateLegs()
  {
    return new HumanLegs();
  }
}

public class MonkeyFactory : IBipedFactory
{
  public IArms CreateArms()
  {
    return new MonkeyArms();
  }

  public ILegs CreateLegs()
  {
    return new MonkeyLegs();
  }
}