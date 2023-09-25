namespace PierresBakery.Models
{
  public abstract class BakedGood
  {
    // auto-implemented properties
    public int Price { get; set; }
    public int NthItemFree { get; set; }
    // static field with virtual property
    // allows a derived class to update its own static field
    private static int _totalItems;
    public virtual int TotalItems 
    { 
      get { return _totalItems; } 
      set { _totalItems = value; }
    }

    // method to calculate cost of user's order
    public int Order(int numberOfItems)
    {
      if (numberOfItems < 0)
      {
        numberOfItems = 0;
      }
      // update static variable
      TotalItems += numberOfItems;
      // number of free items in order = floor of (number of items in the order / nth item that is free)
      int freeItems = TotalItems / NthItemFree;
      int discount = Price * freeItems;
      int orderCost = (TotalItems * Price) - discount;

      return orderCost;
    }
  }
}