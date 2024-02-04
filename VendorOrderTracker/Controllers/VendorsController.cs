using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {

      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    // [HttpGet("/vendors/{id}")]
    // public ActionResult Details(int id)
    // {
    //   Pet foundPet = Pet.Find(id);
    //   return View(foundPet);
    // }

    // [HttpPost("/vendors/{id}")]
    // public ActionResult HandlePetAction(int id, string action)
    // {
    //   Pet pet = Pet.Find(id);

    //   if (pet == null)
    //   {
    //     return NotFound();
    //   }

    //   switch (action)
    //   {
    //     case "attention":
    //       pet.Attention();
    //       break;
    //     case "feed":
    //       pet.Feed();
    //       break;
    //     case "rest":
    //       pet.Rest();
    //       break;

    //     default:
    //       return BadRequest("Invalid action");
    //   }

    //   return RedirectToAction("Details", new { id = pet.Id });
    // }


  }
}