using Builder.Builders;
using Builder.Director;

namespace Builder;

internal class Application
{
  public void Main() 
  {
    var director = new DirectorImp();
    var builder = new WoodHouseBuilder();
    director.Builder = builder;
    director.BuildBigHouse();

    var rockBuilder = new RockHouseBuilder();
    director.Builder = rockBuilder;
    director.BuildSmallHouse();
  }
}