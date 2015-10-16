namespace ChaninOfResponsibility
{
  public interface IBoss : ISupervisor
  {
  }

  public class Boss : IBoss
  {
    #region Implementation of ILeaveProcess

    public void Approved(int noOfLeaves)
    {
      throw new System.NotImplementedException();
    }

    #endregion

    #region Implementation of ISupervisor

    public ISupervisor Supervisor { get; private set; }

    public void RequestForLeave(int noOfLeave)
    {
      throw new System.NotImplementedException();
    }

    #endregion
  }
}