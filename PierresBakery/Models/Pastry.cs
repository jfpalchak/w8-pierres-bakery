//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Pastry
  {

    public int NumberOfPastries { get; }

    public Pastry(int userOrder)
    {
      NumberOfPastries = userOrder;
    }
  }
}