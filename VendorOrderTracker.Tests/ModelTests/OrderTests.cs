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
      string date = "July 3 2022";
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
      string date = "July 3 2022";
      Order newOrder = new Order(orderTitle, description, price, date);

      //Act
      string updatedOrderTitle = "Sourdough";
      newOrder.OrderTitle = updatedOrderTitle;
      string result = newOrder.OrderTitle;

      //Assert
      Assert.AreEqual(updatedOrderTitle, result);
    }

    //no tests written for get and set for other properties; GetOrderTitle and SetOrderTitle sufficient to test default get and set (testing for default get and set is usually not necessary)

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

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnId_Int()
    {
      //Arrange
      string orderTitle = "Croissants";
      string description = "Order of 100";
      int price = 400;
      string date = "July 3 2022";
      Order newOrder = new Order(orderTitle, description, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string orderTitle01 = "Croissants";
      string description = "Order of 100";
      int price = 400;
      string date = "July 3 2020";
      string orderTitle02 = "Sourdough";
      Order newOrder1 = new Order(orderTitle01, description, price, date);
      Order newOrder2 = new Order(orderTitle02, description, price, date);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}