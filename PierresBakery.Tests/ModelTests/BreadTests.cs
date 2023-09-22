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

    // PRICE PROPERTY
    [TestMethod]
    public void GetPrice_ReturnsPriceOfBread_Int()
    {
      Bread newBread = new Bread();

      int price = newBread.Price;

      Assert.AreEqual(5, price);
    }

    // FREE LOAF PROPERTY
    [TestMethod]
    public void GetNthItemFree_ReturnsNthLoafFree_Int()
    {
      Bread newBread = new Bread();

      int nthLoafFree = newBread.NthItemFree;

      Assert.AreEqual(3, nthLoafFree);
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
    public void Order_ReturnsTotalCostOfThreeLoaves_int()
    {
      Bread newBread = new Bread();

      int cost = newBread.Order(3);

      Assert.AreEqual(10, cost);
    }

    [TestMethod]
    public void Order_ReturnsAccurateTotalCostOfManyLoaves_int()
    {
      Bread newBread = new Bread();

      int cost = newBread.Order(7);

      Assert.AreEqual(25, cost);
    }

  }
}