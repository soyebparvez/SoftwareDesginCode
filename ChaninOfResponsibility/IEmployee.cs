namespace ChaninOfResponsibility
{
  public interface IEmployee
  {
    ISupervisor Supervisor { get; }
    void RequestForLeave(int noOfLeave);
  }

  public class Employee : IEmployee
  {
    public Employee(ISupervisor supervisor)
    {
      this.Supervisor = supervisor;
    }

    #region Implementation of IEmployee

    public ISupervisor Supervisor { get; private set; }

    public void RequestForLeave(int noOfLeave)
    {
      Supervisor.Approved(noOfLeave);
    }

    #endregion
  }
}