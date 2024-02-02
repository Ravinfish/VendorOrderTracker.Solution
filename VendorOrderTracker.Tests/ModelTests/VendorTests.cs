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
      Vendor newVendor = new Vendor("Doggo", "Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string name = "Bunker";
      Vendor newVendor = new Vendor(name, "Description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetVendorName_SetsValueOfVendorName_String()
    {
      string name = "Bunker";
      Vendor newVendor = new Vendor(name, "Description");
      string updatedName = "Miss Patty's";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescriptionofVendor_String()
    {
      string description = "Miss Patty's coffee shop";
      Vendor newVendor = new Vendor("Miss Patty's", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
  }
}