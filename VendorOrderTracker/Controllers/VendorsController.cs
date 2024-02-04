using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    //List of vendors to display
    [HttpGet("/vendors")]
    public ActionResult Index()
    {

      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    //Get the form for the new  vendor
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
    //create new vendor
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    //get and show specified vendor details
    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      return View(foundVendor);
    }
    //create a new order for a specific vendor and display order on vendor page
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, float price, string date)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, price, date);
      foundVendor.AddOrder(newOrder);
      return RedirectToAction("Details", foundVendor);
    }
    //can add edit and delete if more time below

  }
}