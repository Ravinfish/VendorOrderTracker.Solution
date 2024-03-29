using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstuctor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Cookie Order", "5 orders at $2 each.", 10, "02/03/2024");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "Bread Order";
      Order newOrder = new Order(title, "10 Orders at $5 each.", 50, "9/29/2023");

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string description = "5 orders at $2 each.";
      Order newOrder = new Order("Cookie Order", description, 10, "02/03/2024");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOfOrder_Float()
    {
      float price = 10.10f;
      Order newOrder = new Order("Cookie Order", "5 Orders.", price, "02/03/2024");
      float result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnDateOfOrder_String()
    {
      string date = "02/03/2024";
      Order newOrder = new Order("Cookie Order", "5 Orders.", 10, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfOrders_OrderList()
    {
      Order newOrder1 = new Order("Title", "Description", 10, "Date");
      Order newOrder2 = new Order("Title", "Description", 20, "Date");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearsListOfAllOrders_Void()
    {
      List<Order> newList = new List<Order> { };
      Order newOrder1 = new Order("Title", "Description", 10, "Date");
      Order newOrder2 = new Order("Title", "Description", 20, "Date");
      Order.ClearAll();
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersAreInstantiatedWithAnIdAndGetterReturnsId_Int()
    {
      Order newOrder = new Order("Title", "Description", 10, "Date");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrder1 = new Order("Title", "Description", 10, "Date");
      Order newOrder2 = new Order("Title", "Description", 20, "Date");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }

}