using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryAdmin.Models;
using System.Collections.Generic;
using System;

namespace BakeryAdmin.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "text");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "name";
      string description = "description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_vendorList()
    {
      string name01 = "Work";
      string description = "descrip";
      string name02 = "School";
      string description02 = "school";
      Vendor newVendor1 = new Vendor(name01,description);
      Vendor newVendor2 = new Vendor(name02,description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "random text";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      
      string name01 = "Greetings";
      string answer = "Fellow";
      string name02 = "Programs";
      Vendor newVendor1 = new Vendor(name01,answer);
      Vendor newVendor2 = new Vendor(name02,answer);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }







    
  }
}
