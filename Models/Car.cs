using System;

namespace Dealership.Models {
  public class Car
  { // Public properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    // Constructor
    public Car(string makeModel, int price, int miles)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
    }




    // Without properties
    // private string _makeModel;
    // private int _price;
    // private int _miles;

    // public Car(string makeModel, int price, int miles)
    // {
    //   _makeModel = makeModel;
    //   _price = price;
    //   _miles = miles;
    // }
    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    // public void SetPrice(int newPrice)
    // {
    //   _price = newPrice;
    // }
    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}