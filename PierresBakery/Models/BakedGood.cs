namespace PierresBakery.Models
{
  public abstract class BakedGood
  {
    // auto-implemented properties
    public int Price { get; set; }
    public int NthItemFree {get; set; }

    public int Order(int numberOfItems)
    {
      if (numberOfItems < 0)
      {
        numberOfItems = 0;
      }
      // calculate how many baked good items in the order is free
      // number of items in the order / nth item that is free = (whole integer, rounded down)
      int freeItems = numberOfItems / NthItemFree;
      // calculate value of discount according to number of free items in user's order
      int discount = Price * freeItems;
      // calculate order's total cost and subtract discount
      int orderCost = (numberOfItems * Price) - discount;
      return orderCost;
    }
  }
}