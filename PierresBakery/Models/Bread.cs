//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; } = 5;
    public int NumberOfLoaves { get; set; }

    // constructor
    public Bread(int userOrder)
    {
      NumberOfLoaves = userOrder;
    }
  }
}