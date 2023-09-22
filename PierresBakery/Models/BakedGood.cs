namespace PierresBakery.Models
{
  public abstract class BakedGood
  {
    // auto-implemented properties
    public int Price { get; set; }
    public int NthItemFree { get; set; }

    // create static field
    // update field with virtual property
    private static int _orderTotal;
    public virtual int OrderTotal 
    { 
      get { return _orderTotal; } 
      set { _orderTotal = value; }
    }

    public int Order(int numberOfItems)
    {
      if (numberOfItems < 0)
      {
        numberOfItems = 0;
      }
      // calculate how many baked good items in the order are free:
      // number of items in the order / nth item that is free = (whole integer, rounded down)
      int freeItems = numberOfItems / NthItemFree;
      // calculate value of discount according to number of free items in user's order
      int discount = Price * freeItems;
      // calculate order's total cost and subtract discount
      int orderCost = (numberOfItems * Price) - discount;
      
      // update static variable
      OrderTotal += orderCost;
      return OrderTotal;
    }
  }
}