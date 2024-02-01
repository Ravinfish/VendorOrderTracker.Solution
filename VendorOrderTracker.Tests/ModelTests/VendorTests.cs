using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Doggo");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string name = "Bunker";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetVendorName_SetsValueOfVendorName_String()
    {
      string name = "Bunker";
      Vendor newVendor = new Vendor(name);
      string updatedName = "Miss Patty's";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }
  }
}