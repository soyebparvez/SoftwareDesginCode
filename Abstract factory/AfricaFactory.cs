
namespace Abstract_factory
{
  public class AfricaFactory : ContinentFactory
  {
    public override Herbivore CreateHerbivore()
    {
      return new Wildebeest();
    }

    public override Carnivore CreateCarnivore()
    {
      return new Lion();
    }
  }
}
