namespace Builder.Builders;

public interface IBuilderHouse 
{
  void BuildWalls();
  void BuildRoof();
  void BuildWindows(int windowsNum);
  void BuildFloor(int floorSize);
}

public class WoodHouseBuilder : IBuilderHouse
{
  private WoodHouse _house;

  public void BuildFloor(int floorSize)
  {
    _house.Floor = floorSize;
  }

  public void BuildRoof()
  {
    _house.Roof = "Wood Roof";
  }

  public void BuildWalls()
  {
    _house.Wall = "Wood Wall";
  }

  public void BuildWindows(int windowsNum)
  {
    _house.Windows = windowsNum;
  }

  public WoodHouseBuilder() 
  {
    _house = new WoodHouse();
  }

  public void Reset() 
  {
    _house = new WoodHouse();
  }

  public WoodHouse GetHouse() 
  {
    this.Reset();
    return _house;
  }
}

public class WoodHouse
{
  public int Floor { get; set;}
  public string? Roof { get; set;}
  public string? Wall { get; set;}
  public int Windows { get; set;}
}

public class RockHouseBuilder : IBuilderHouse
{
  private RockHouse _house;

  public void BuildFloor(int floorSize)
  {
    _house.Floor = floorSize;
  }

  public void BuildRoof()
  {
    _house.Roof = "Rock Roof";
  }

  public void BuildWalls()
  {
    _house.Wall = "Rock Wall";
  }

  public void BuildWindows(int windowsNum)
  {
    _house.Windows = windowsNum;
  }

  public RockHouseBuilder() 
  {
    _house = new RockHouse();
  }

  public void Reset() 
  {
    _house = new RockHouse();
  }

  public RockHouse GetHouse() 
  {
    this.Reset();
    return _house;
  }
}

public class RockHouse
{
  public int Floor { get; set;}
  public string? Roof { get; set;}
  public string? Wall { get; set;}
  public int Windows { get; set;}
}
