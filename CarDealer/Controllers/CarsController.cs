using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;

namespace CarDealer.Controllers
{
    public class CarsController : Controller
    {

        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }


        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/cars")]
        public ActionResult Create(string makeandmodel, string price, string miles, string description)
        {
            Car myCar = new Car(makeandmodel, price, miles, description);
            myCar.Save();
            return RedirectToAction("Index");
        }
    }
}