//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Pastry
  {
    public static int Price { get; } = 2;
    public static int NthPastryFree { get; } = 4;

    // calculate total cost of user's order
    public static int Order(int NumberOfPastries)
    {
      // calculate number of free pastries in user's order =
      // number of pastries in order / nth pastry that is free (whole integer, rounded down)
      int freePastries = NumberOfPastries / NthPastryFree;
      // calculate discount according to number of free pastries in user's order
      int discount = Price * freePastries;
      // calculate order's total cost and subtract discount
      int orderCost = (NumberOfPastries * Price) - discount;
      return orderCost;
    }
  }
}