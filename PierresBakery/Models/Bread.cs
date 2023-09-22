//USING DIRECTIVES HERE

namespace PierresBakery.Models
{
  public class Bread
  {
    // auto-implemented property
    public int NumberOfLoaves { get; set; }

    // constructor
    public Bread(int userOrder)
    {
      NumberOfLoaves = userOrder;
    }
  }
}