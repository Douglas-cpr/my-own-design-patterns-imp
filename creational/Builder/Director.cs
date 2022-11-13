using Builder.Builders;

namespace Builder.Director;

// Orchestrator
public class DirectorImp
{
  private IBuilderHouse _builder;
  public IBuilderHouse Builder { set { _builder = value; }}

  public void BuildSmallHouse() 
  {
    _builder.BuildFloor(10);
    _builder.BuildWalls();
    _builder.BuildWindows(4);
    _builder.BuildRoof();
  }

  public void BuildBigHouse() 
  {
    _builder.BuildFloor(50);
    _builder.BuildWalls();
    _builder.BuildWindows(15);
    _builder.BuildRoof();
  }
}
