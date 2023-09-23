namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
    // update new static field with inherited virtual property
    private static int _totalBreadItems;
    public override int TotalItems
    {
      get { return _totalBreadItems; }
      set { _totalBreadItems = value; }
    }

    public Bread()
    {
      Price = 5;
      NthItemFree = 3;
    }

    // reset total for bread orders
    public static void ClearOrder()
    {
      _totalBreadItems = 0;
    }
  }
}