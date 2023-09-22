//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int Price { get; } = 5;
    public static int NthLoafFree {get; } = 3;
    
    // calculate total cost of user's bread order
    public static int Order(int NumberOfLoaves)
    {
      // calculate how many loaves in the order is free = 
      // number of loaves in the order / nth loaf of bread that is free (whole integer, rounded down)
      int freeLoaves = NumberOfLoaves / 3;
      // calculate value of discount according to number of free loaves in user's order
      int discount = Price * freeLoaves;
      // calculate order's total cost and subtract discount
      int orderCost = (NumberOfLoaves * Price) - discount;
      return orderCost;
    }
  }
}