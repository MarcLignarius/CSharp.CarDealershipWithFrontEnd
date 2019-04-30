using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Cars> allCars = Cars.GetAll();
      return View(allCars);
    }

    [Route("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    // [HttpPost("/cars")]
    // public ActionResult Create(string makeModel, string color, int mileage, int price)
    // {
    //   Cars myCar = new Cars(makeModel, color, mileage, price);
    //   return RedirectToAction("Index");
    // }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel)
    {
      Cars myCar = new Cars(makeModel);
      return RedirectToAction("Index");
    }

  }
}
