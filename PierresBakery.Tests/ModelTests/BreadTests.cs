using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);

      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfBread_Int()
    {
      Bread newBread = new Bread(3);

      Assert.AreEqual(5, newBread.Price);
    }

    [TestMethod]
    public void GetNumberOfLoaves_ReturnsNumberOfLoaves_Int()
    {
      int numOfLoaves = 3;
      Bread newBread = new Bread(numOfLoaves);

      int result = newBread.NumberOfLoaves;

      Assert.AreEqual(numOfLoaves, result);
    }

    [TestMethod]
    public void SetNumberOfLoaves_SetsValueOfNumberOfLoaves_Void()
    {
      Bread newBread = new Bread(3);
      int newOrder = 5;

      newBread.NumberOfLoaves = newOrder;
      
      Assert.AreEqual(newOrder, newBread.NumberOfLoaves);
    }    

    [TestMethod]
    public void Order_ReturnsCostOfSingleLoaf_Int()
    {
      Bread newBread = new Bread(1);

      int cost = newBread.Order(); // ! this tells me i probably don't need a constructor

      Assert.AreEqual(5, cost);
    }

    [TestMethod]
    public void Order_ReturnsTotalCostOfTwoLoaves_Int()
    {
      Bread newBread = new Bread(2);

      int cost = newBread.Order();

      Assert.AreEqual(10, cost);
    }
  }
}