using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string orderTitle = "Croissants";
      Order newOrder = new Order(orderTitle);

      //Act
      string result = newOrder.OrderTitle;

      //Assert
      Assert.AreEqual(orderTitle, result);
    }

        [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      //Arrange
      string orderTitle = "Croissants";
      Order newOrder = new Order(orderTitle);

      //Act
      string updatedOrderTitle = "Sourdough";
      newOrder.OrderTitle = updatedOrderTitle;
      string result = newOrder.OrderTitle;

      //Assert
      Assert.AreEqual(updatedOrderTitle, result);
    }
  }
}