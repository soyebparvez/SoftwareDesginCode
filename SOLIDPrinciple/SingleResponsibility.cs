namespace SOLIDPrinciple
{
  public class Employee
  {
    public string Name { get; set; }
    public string Address { get; set; }
    public string ID { get; set; }
    public double GetSalary()
    {
      double basic = 10000.00;
      double hra = 5000.00;
      double others = 10000;

      return basic + hra + others;
    }
  }

  public interface IExtendedEmployee
  {
    string Name { get; set; }
    string Address { get; set; }
    string ID { get; set; }
  }

  public class ExtendedEmplyoee : IExtendedEmployee
  {
    #region Implementation of IExtendedEmplyee

    public string Name { get; set; }
    public string Address { get; set; }
    public string ID { get; set; }

    #endregion
  }


  public class EmployeeSalaryCalculator
  {
    public double CalculateEmployeeSalary(IExtendedEmployee extendedEmplyee)
    {
      // Here some other class or data base give salary component for
      // against particular employee id.

      double basic = 10000.00;
      double hra = 5000.00;
      double others = 10000;

      return basic + hra + others;
    }
  }
}
