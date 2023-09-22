using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  [TestClass]
  public class BreadTests
  {
    // BREAD CONSTRUCTOR
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();

      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_InheritsFromAbstractClassBakedGood_Bread()
    {
      Bread newBread = new Bread();

      Assert.IsTrue(typeof(BakedGood).IsAssignableFrom(newBread.GetType()));
    }

    // INHERITED PRICE PROPERTY
    [TestMethod]
    public void GetPrice_ReturnsPriceOfBread_Int()
    {
      Bread newBread = new Bread();

      int price = newBread.Price;

      Assert.AreEqual(5, price);
    }

    [TestMethod]
    public void SetPrice_SetsPriceValueOfBread_Void()
    {
      Bread newBread = new Bread();
      int newPrice = 10;

      newBread.Price = newPrice;

      Assert.AreEqual(newPrice, newBread.Price);
    }

    // INHERITED NTH ITEM FREE PROPERTY
    [TestMethod]
    public void GetNthItemFree_ReturnsNthLoafFree_Int()
    {
      Bread newBread = new Bread();

      int nthLoafFree = newBread.NthItemFree;

      Assert.AreEqual(3, nthLoafFree);
    }

    [TestMethod]
    public void SetNthItemFree_SetsValueOfNthLoafFree_Void()
    {
      Bread newBread = new Bread();
      int newDeal = 10;

      newBread.NthItemFree = newDeal;

      Assert.AreEqual(newDeal, newBread.NthItemFree);
    }

    // INHERITED ORDER METHOD
    [TestMethod]
    public void Order_ReturnsCostOfSingleLoaf_Int()
    {
      Bread newBread = new Bread();

      int cost = newBread.Order(1); 

      Assert.AreEqual(5, cost);
    }

    [TestMethod]
    public void Order_ReturnsTotalCostOfTwoLoaves_Int()
    {
      Bread newBread = new Bread();

      int cost = newBread.Order(2);

      Assert.AreEqual(10, cost);
    }

    [TestMethod]
    public void Order_ReturnsTotalCostOfThreeLoaves_Int()
    {
      Bread newBread = new Bread();

      int cost = newBread.Order(3);

      Assert.AreEqual(10, cost);
    }

    [TestMethod]
    public void Order_ReturnsAccurateTotalCostOfManyLoaves_Int()
    {
      Bread newBread = new Bread();

      int cost = newBread.Order(7);

      Assert.AreEqual(25, cost);
    }

    [TestMethod]
    public void Order_ReturnsZeroIfOrderNumberIsZeroOrLess_Int()
    {
      Bread newBread = new Bread();
      
      int cost = newBread.Order(-3);

      Assert.AreEqual(0, cost);
    }

  }
}