using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    // Teardown Interface
    public void Dispose()
    {
      Pastry.ClearOrder();
    }

    // PASTRY CONSTRUCTOR
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();

      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_InheritsFromAbstractClassBakedGood_Pastry()
    {
      Pastry newPastry = new Pastry();

      Assert.IsTrue(typeof(BakedGood).IsAssignableFrom(newPastry.GetType()));
    }

    // INHERITED PRICE PROPERTY
    [TestMethod]
    public void GetPrice_ReturnsPriceOfPastry_Int()
    {
      Pastry newPastry = new Pastry();

      int price = newPastry.Price;

      Assert.AreEqual(2, price);
    }

    [TestMethod]
    public void SetPrice_SetsPriceValueOfPastry_Void()
    {
      Pastry newPastry = new Pastry();
      int newPrice = 10;

      newPastry.Price = newPrice;
      
      Assert.AreEqual(newPrice, newPastry.Price);
    }

    // INHERITED NTH ITEM FREE PROPERTY
    [TestMethod]
    public void GetNthItemFree_ReturnsNthPastryThatIsFree_Int()
    {
      Pastry newPastry = new Pastry();

      int nthPastryFree = newPastry.NthItemFree;

      Assert.AreEqual(4, nthPastryFree);
    }

    [TestMethod]
    public void SetNthItemFree_SetsValueOfNthPastryThatIsFree_Void()
    {
      Pastry newPastry = new Pastry();
      int newDeal = 10;

      newPastry.NthItemFree = newDeal;

      Assert.AreEqual(newDeal, newPastry.NthItemFree);
    }

    // INHERITED ORDER METHOD
    [TestMethod]
    public void Order_ReturnsCostOfSinglePastry_Int()
    {
      Pastry newPastry = new Pastry();

      int cost = newPastry.Order(1);

      Assert.AreEqual(2, cost);
    }

    [TestMethod]
    public void Order_ReturnsCostOfTwoPastries_Int()
    {
      Pastry newPastry = new Pastry();

      int cost = newPastry.Order(2);

      Assert.AreEqual(4, cost);
    }

    [TestMethod]
    public void Order_ReturnsCostOfFourPastries_Int()
    {
      Pastry newPastry = new Pastry();

      int cost = newPastry.Order(4);

      Assert.AreEqual(6, cost);
    }

    [TestMethod]
    public void Order_ReturnsAccurateCostOfManyPastries_Int()
    {
      Pastry newPastry = new Pastry();

      int cost = newPastry.Order(8);

      Assert.AreEqual(12, cost);
    }

    [TestMethod]
    public void Order_ReturnsZeroIfOrderNumberIsZeroOrLess_Int()
    {
      Pastry newPastry = new Pastry();
      
      int cost = newPastry.Order(-3);

      Assert.AreEqual(0, cost);
    }

    // ORDER TOTAL
    [TestMethod]
    public void Order_UpdatesTotalItemsStaticVariableWithEachOrder_Int()
    {
      Pastry newPastry = new Pastry();

      int firstOrder = newPastry.Order(1);
      int secondOrder = newPastry.Order(1);

      Assert.IsTrue(firstOrder == 2 && secondOrder == 4);
    }

    [TestMethod]
    public void GetTotalItems_ReturnsTotalOrderOfPastries_Int()
    {
      Pastry newPastry = new Pastry();

      int firstOrder = newPastry.Order(1);
      int newOrder = newPastry.Order(1);

      Assert.AreEqual(2, newPastry.TotalItems);
    }

    [TestMethod]
    public void SetTotalItems_SetsValueOfTotalNumberOfPastries_Void()
    {
      Pastry newPastry = new Pastry();
      int initialCount = newPastry.TotalItems;
      int newCount = 10;

      newPastry.TotalItems = newCount;

      Assert.AreEqual(0, initialCount);
      Assert.AreEqual(newCount, newPastry.TotalItems);
    }

    // CLEAR ORDER METHOD
    [TestMethod]
    public void ClearOrder_ResetsTotalOfPastryOrders_Void()
    {
      Pastry newPastry = new Pastry();

      int firstOrder = newPastry.Order(1);
      int secondOrder = newPastry.Order(1);

      Pastry.ClearOrder();

      Assert.AreEqual(0, newPastry.TotalItems);
    }
  }
}