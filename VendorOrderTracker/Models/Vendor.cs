using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; }

    private static List<Vendor> _instances = new List<Vendor> {};
    public int Id { get;}
    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      Orders = new List<Order> {};
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void AddOrder(Order newOrder)
    {
      Orders.Add(newOrder);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}