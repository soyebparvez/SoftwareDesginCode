namespace ChaninOfResponsibility
{
  using System;

  public interface ITechnicalManager : ISupervisor
  {
  }

  public class TechnicalManager : ITechnicalManager
  {
    public TechnicalManager(ISupervisor supervisor)
    {
      this.Supervisor = supervisor;
    }

    #region Implementation of ISupervisor

    public ISupervisor Supervisor { get; private set; }

    public void RequestForLeave(int noOfLeave)
    {
      Supervisor.Approved(noOfLeave);
    }

    #endregion

    #region Implementation of ILeaveProcess

    public void Approved(int noOfLeaves)
    {
      if (noOfLeaves <= 10)
      {
        Console.WriteLine("Leaves has approved by " + this.GetType().Name);
      }
      else
      {
        Supervisor.Approved(noOfLeaves);
      }
    }

    #endregion
  }
}