using System.Collections.Generic;
using System;

namespace CarDealer.Models
{
  public class Car
  {
    
    private string _makeModel;
    private string _price;
    private string _miles;
    private string _description;


    private static List<Car> _instances = new List<Car> {};

    public Car (string makeModel, string price, string miles, string description)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _description = description;
     
    }

    public string GetModel()
    {
      return _makeModel;
    }

    public void SetModel(string newModel)
    {
      _makeModel= newModel;
    }

     public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

     public string GetPrice()
    {
      return _price;
    }

    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }

     public string GetMiles()
    {
      return _miles;
    }

    public void SetMiles(string newMiles)
    {
      _miles = newMiles;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}



// namespace Dealership {

//   class Car
//   {
//     private string MakeModel;
//     private int Price;
//     private int Miles;
//     private string Message;
    
//     public Car(string makeModel, int price, int miles, string message)
    
//     {
//       MakeModel = makeModel;
//       Price = price;
//       Miles = miles;
//       Message = message;
//     }

//     public string GetMakeModel()
//     {
//       return MakeModel;
//     }

//     public int GetPrice()
//     {
//       return Price;
//     }

//     public void SetPrice(int newPrice)
//     {
//       Price = newPrice;
//     }

//     public int GetMiles()
//     {
//       return Miles;
//     }

//     public string GetMessage()
//     {
//       return Message;
//     } 

//     public bool WorthBuying(int maxPrice, int maxMiles)
//     {
//       return (Price < maxPrice && Miles < maxMiles);
//     }
//   }

// }