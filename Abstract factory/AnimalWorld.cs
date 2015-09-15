namespace Abstract_factory
{
  class AnimalWorld
  {
    private Herbivore m_herbivore;
    private Carnivore m_carnivore;

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

