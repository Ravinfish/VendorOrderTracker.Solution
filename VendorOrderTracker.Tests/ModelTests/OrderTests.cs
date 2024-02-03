using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstuctor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Cookie Order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "Cookie Order";
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

  }
  
}