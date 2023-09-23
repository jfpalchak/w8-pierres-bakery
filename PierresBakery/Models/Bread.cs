namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
    // update new static field with inherited virtual property
    private static int _orderTotalBread;
    public override int OrderTotal
    {
      get { return _orderTotalBread; }
      set { _orderTotalBread = value; }
    }

    public Bread()
    {
      Price = 5;
      NthItemFree = 3;
    }

    // reset total for bread orders
    public static void ClearOrder()
    {
      _orderTotalBread = 0;
    }
  }
}