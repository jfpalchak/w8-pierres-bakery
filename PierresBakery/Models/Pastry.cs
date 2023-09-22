//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Pastry : BakedGood
  {
    // create new static field
    // update new static field with inherited virtual property
    private static int _orderTotalPastry;
    public override int OrderTotal
    {
      get { return _orderTotalPastry; }
      set { _orderTotalPastry = value; }
    }

    public Pastry()
    {
      Price = 2;
      NthItemFree = 4;
    }

    public static void ClearOrder()
    {
      _orderTotalPastry = 0;
    }
  }
}