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

    public int Order()
    {
      int freePastries = NumberOfPastries / 4;
      int discount = Price * freePastries;
      int orderCost = (NumberOfPastries * Price) - discount;
      return orderCost;
    }
  }
}