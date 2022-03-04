using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 0, "testDate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      //Arrange
      string orderTitle = "Croissants";
      string description = "Order of 100";
      int price = 400;
      string date = "July 3 2020";
      Order newOrder = new Order(orderTitle, description, price, date);

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
      string description = "Order of 100";
      int price = 400;
      string date = "July 3 2020";
      Order newOrder = new Order(orderTitle, description, price, date);

      //Act
      string updatedOrderTitle = "Sourdough";
      newOrder.OrderTitle = updatedOrderTitle;
      string result = newOrder.OrderTitle;

      //Assert
      Assert.AreEqual(updatedOrderTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      //Arrange
      List<Order> newList = new List<Order> { };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}