using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864, "sick car");
      Car ford = new Car("2011 Ford F450", 55995, 14241, "total piece of junk");
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "drive away today!");
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "who wants a benzo?");

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter maximum miles: ");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      
        foreach(Car automobile in CarsMatchingSearch)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(automobile.GetMakeModel());
            Console.WriteLine(automobile.GetMiles() + " miles");
            Console.WriteLine("$" + automobile.GetPrice());
            Console.WriteLine(automobile.GetMessage());
        }
      
      if (CarsMatchingSearch.Count==0)
      {
        Console.WriteLine("Sorry, no cars match that search");
      }
      
       
      
    }
  }

}