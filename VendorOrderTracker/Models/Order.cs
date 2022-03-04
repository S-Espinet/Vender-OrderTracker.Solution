using System.Collections.Generic;

namespace VendorOrderTracker.Models
{

  public class Order
  {
    public string OrderTitle { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};
    public Order(string orderTitle, string description, int price, string date)
    {
      OrderTitle = orderTitle;
      Description = description;
      Price = price;
      Date = date;
      Id = 0;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}