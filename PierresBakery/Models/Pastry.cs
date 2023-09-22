//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price { get; } = 2;
    public int NumberOfPastries { get; set; }

    public Pastry(int userOrder)
    {
      NumberOfPastries = userOrder;
    }

    // calculate total cost of user's order
    public int Order()
    {
      // calculate number of free pastries in user's order =
      // number of pastries in order / nth pastry that is free (whole integer, rounded down)
      int freePastries = NumberOfPastries / 4;
      // calculate discount according to number of free pastries in user's order
      int discount = Price * freePastries;
      // calculate order's total cost and subtract discount
      int orderCost = (NumberOfPastries * Price) - discount;
      return orderCost;
    }
  }
}