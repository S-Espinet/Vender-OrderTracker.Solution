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
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      //Arrange
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
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
      string vendorDescription = "Test Description";
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
      string description01 = "Test Description1";
      string vendorName02 = "Suzie's Cafe";
      string description02 = "Test Description1";
      Vendor newVendor1 = new Vendor(vendorName01, description01);
      Vendor newVendor2 = new Vendor(vendorName02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}