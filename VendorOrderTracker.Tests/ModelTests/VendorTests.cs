using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      //Arrange
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Vendor Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      //Act
      string result = newVendor.VendorName;

      //Assert
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetVendorName_SetsVendorName_String()
    {
      //Arrange
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Vendor Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      //Act
      string updatedVendorName = "Suzie's Cafe";
      newVendor.VendorName = updatedVendorName;
      string result = newVendor.VendorName;

      //Assert
      Assert.AreEqual(updatedVendorName, result);
    }

//no tests written for get and set for other properties; GetVendorName and SetVendorName sufficient to test default get and set (testing for default get and set is usually not necessary)

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string vendorName01 = "Test Vendor";
      string vendorDescription01 = "Test Vendor Description1";
      string vendorName02 = "Suzie's Cafe";
      string vendorDescription02 = "Test Vendor Description2";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Vendor Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string vendorName01 = "Test Vendor";
      string vendorName02 = "Suzie's Cafe";
      string vendorDescription = "Test Vendor Description";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

  [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
  {
    //Arrange
    string orderTitle = "Croissants";
    string description = "Order of 100";
    int price = 400;
    string date = "July 3 2022";
    Order newOrder = new Order(orderTitle, description, price, date);
    List<Order> newList = new List<Order> { newOrder };
    string vendorName = "Test Vendor";
    string vendorDescription = "Test Vendor Description";
    Vendor newVendor = new Vendor(vendorName, vendorDescription);
    newVendor.AddOrder(newOrder);

    //Act
    List<Order> result = newVendor.Orders;

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }
  }
}