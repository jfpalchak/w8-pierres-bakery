//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; } = 5;
    public int NumberOfLoaves { get; set; }

    public Bread(int userOrder)
    {
      NumberOfLoaves = userOrder;
    }

    public int Order()
    {
      // calculate how many loaves in the order is free = 
      // number of loaves in the order / nth loaf of bread that is free
      // (whole integer, rounded down)
      int freeLoaves = NumberOfLoaves / 3;
      // calculate value of discount according to number of free loaves in user's order
      int discount = Price * freeLoaves;
      // calculate order's total cost and subtract discount
      int orderCost = (NumberOfLoaves * Price) - discount;
      return orderCost;
    }
  }
}