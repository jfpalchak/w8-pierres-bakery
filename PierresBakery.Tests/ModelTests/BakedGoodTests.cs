using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakedGoodTests
  {
    [TestMethod]
    public void BakedGood_IsParentClassOfBreadClass_BakedGood()
    {
      Assert.IsTrue(typeof(BakedGood).IsAssignableFrom(typeof(Bread)));
    }

    [TestMethod]
    public void BakedGood_IsParentClassOfPastryClass_BakedGood()
    {
      Assert.IsTrue(typeof(BakedGood).IsAssignableFrom(typeof(Pastry)));
    }
  }
}