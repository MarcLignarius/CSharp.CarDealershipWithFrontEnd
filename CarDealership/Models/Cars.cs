using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Cars
  {
    private string _makeModel;
    // private string _color;
    // private int _mileage;
    // private int _price;
    private static List<Cars> _instances = new List<Cars> {};

    // public Cars (string makeModel, string color, int mileage, int price)
    // {
    //   _makeModel = makeModel;
    //   // _color = color;
    //   // _mileage = mileage;
    //   // _price = price;
    //   _instances.Add(this);
    // }

    public Cars (string makeModel)
    {
      _makeModel = makeModel;
      // _color = color;
      // _mileage = mileage;
      // _price = price;
      _instances.Add(this);
    }

    public string makeModel { get => _makeModel; set => _makeModel = value;}
    // public string color { get => _color; set => _color = value;}
    // public int mileage { get => _mileage; set => _mileage = value;}
    // public int price { get => _price; set => _price = value;}

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
