namespace PierresBakery.Models
{
  public class Pastry : BakedGood
  {
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

    // reset total for pastry orders
    public static void ClearOrder()
    {
      _orderTotalPastry = 0;
    }
  }
}