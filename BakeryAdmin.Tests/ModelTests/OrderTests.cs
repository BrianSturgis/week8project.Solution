using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryAdmin.Models;
using System;

namespace BakeryAdmin.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("1","2","3","4");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "21";

      //Act
      Order newOrder = new Order("1","2","3","4");
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }



  }
}