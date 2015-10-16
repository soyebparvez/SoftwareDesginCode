using System;

namespace ChaninOfResponsibility
{
  public class Program
  {
    public static void Main(string[] args)
    {
      ISupervisor director = new Director(new Boss());
      ISupervisor manager = new TechnicalManager(director);
      ISupervisor techLead = new TechLead(manager);

      IEmployee employee = new Employee(techLead);
      employee.RequestForLeave(10);

      Console.ReadKey();
    }
  }
}
