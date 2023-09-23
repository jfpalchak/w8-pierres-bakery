namespace PierresBakery.Models
{
  public class Pastry : BakedGood
  {
    // update new static field with inherited virtual property
    private static int _totalPastryItems;
    public override int TotalItems
    {
      get { return _totalPastryItems; }
      set { _totalPastryItems = value; }
    }

    // pastry constructor sets inherited properties
    public Pastry()
    {
      Price = 2;
      NthItemFree = 4;
    }

    // reset total for pastry orders
    public static void ClearOrder()
    {
      _totalPastryItems = 0;
    }
  }
}