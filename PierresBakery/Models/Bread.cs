//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
    public Bread()
    {
      Price = 5;
      NthItemFree = 3;
    }
    
    // calculate total cost of user's bread order
    // public static int Order(int numberOfLoaves)
    // {
    //   // calculate how many loaves in the order is free = 
    //   // number of loaves in the order / nth loaf of bread that is free (whole integer, rounded down)
    //   int freeLoaves = numberOfLoaves / NthLoafFree;
    //   // calculate value of discount according to number of free loaves in user's order
    //   int discount = Price * freeLoaves;
    //   // calculate order's total cost and subtract discount
    //   int orderCost = (numberOfLoaves * Price) - discount;
    //   return orderCost;
    // }
  }
}