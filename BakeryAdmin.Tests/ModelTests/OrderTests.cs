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
      string description = "2";

      //Act
      Order newOrder = new Order("1","2","3","4");
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
  [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "1";
      Order newItem = new Order("1","2","3","4");

      //Act
      string updatedDescription = "Greetings Programs";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newOrder = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newOrder, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      
      Order newOrder1 = new Order("a","b","c","d");
      Order newOrder2 = new Order("a","b","c","d");
      List<Order> newOrder = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newOrder, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      
      Order newOrder = new Order("1","1","1");

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    
  }
}