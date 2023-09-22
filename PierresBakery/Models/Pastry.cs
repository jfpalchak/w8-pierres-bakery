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
      return Price;
    }
  }
}