using System.Collections.Generic;

namespace VendorOrderTracker.Models
{

  public class Order
  {
    public string OrderTitle { get; set; }
    public Order(string orderTitle)
    {
      OrderTitle = orderTitle;
    }
  }
}