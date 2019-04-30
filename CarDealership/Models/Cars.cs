using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Cars
  {
    private string _description;
    private static List<Cars> _instances = new List<Cars> {};

    public Cars (string description)
    {
      _description = description;
      _instances.Add(this);
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<Cars> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
