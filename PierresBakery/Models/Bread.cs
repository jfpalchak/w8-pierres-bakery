//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
    // create new static field
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

    public static void ClearOrder()
    {
      _orderTotalBread = 0;
    }
  }
}