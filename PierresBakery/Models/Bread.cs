//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves { get; }

    public Bread(int userOrder)
    {
      NumberOfLoaves = userOrder;
    }
  }
}