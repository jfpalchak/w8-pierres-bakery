namespace PierresBakery.Models
{
  public abstract class BakedGood
  {
    public int Price { get; set; }
    public int NthItemFree {get; set; }

    public virtual int Order(int numberOfLoaves)
    {
      // calculate how many loaves in the order is free = 
      // number of loaves in the order / nth loaf of bread that is free (whole integer, rounded down)
      int freeLoaves = numberOfLoaves / NthItemFree;
      // calculate value of discount according to number of free loaves in user's order
      int discount = Price * freeLoaves;
      // calculate order's total cost and subtract discount
      int orderCost = (numberOfLoaves * Price) - discount;
      return orderCost;
    }
  }
}