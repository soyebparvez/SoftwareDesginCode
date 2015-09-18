namespace Abstract_factory
{
  public class AnimalWorld
  {
    private readonly Herbivore m_herbivore;
    private readonly Carnivore m_carnivore;

    // Constructor
    public AnimalWorld(ContinentFactory factory)
    {
      m_carnivore = factory.CreateCarnivore();
      m_herbivore = factory.CreateHerbivore();
    }

    public void RunFoodChain()
    {
      m_carnivore.Eat(m_herbivore);
    }
  }
}
