
namespace Abstract_factory
{
  class AmericaFactory : ContinentFactory
  {
    public override Herbivore CreateHerbivore()
    {
      return new Bison();
    }

    public override Carnivore CreateCarnivore()
    {
      return new Wolf();
    }

  }
}
