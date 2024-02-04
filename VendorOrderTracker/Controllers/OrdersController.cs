using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    //get form for new order
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      return View(foundVendor);
    }
    //get orders details
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);

      Dictionary<string, object> model = new Dictionary<string, object> {};
      
      model.Add("vendor", foundVendor);
      model.Add("order", foundOrder);
      return View(model);
    }
    //update order details and display that orders page
    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Update(int vendorId, int orderId, string newTitle, string newDescription, float newPrice, string newDate)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);

      foundOrder.Title = newTitle;
      foundOrder.Description = newDescription;
      foundOrder.Price = newPrice;
      foundOrder.Date = newDate;

      Dictionary<string, object> model = new Dictionary<string, object> {};
      
      model.Add("vendor", foundVendor);
      model.Add("order", foundOrder);

      return View("Show", model);
    }

  }
}