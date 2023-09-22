using PierresBakery.Models;
using System;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();

      Console.WriteLine("==============================================");
      Console.WriteLine("Welcome to the order page for Pierre's Bakery!");
      Console.WriteLine("The bakery currently has the following items:");
      Console.WriteLine(" ---------------------------------------------");
      Console.WriteLine("|     Bread: {0:C} |    Buy 2, get 1 free!    |", newBread.Price);
      Console.WriteLine("|    Pastry: {0:C} |    Buy 3, get 1 free!    |", newPastry.Price);
      Console.WriteLine(" ---------------------------------------------");
      Console.WriteLine("How many loaves of bread would you like?");
      Console.WriteLine("Please enter a whole number:");
      string breadOrderString = Console.ReadLine();
      Console.WriteLine("How many pastries would you like?");
      Console.WriteLine("Please enter a whole number:");
      string pastryOrderString = Console.ReadLine();

      int breadOrder = int.Parse(breadOrderString);
      int breadCost = newBread.Order(breadOrder);
      int pastryOrder = int.Parse(pastryOrderString);
      int pastryCost = newPastry.Order(pastryOrder);

      Console.WriteLine("Here's your order:");
      Console.WriteLine(" ---------------------------------------------");
      Console.WriteLine("          Bread Order: {0:C}", breadCost);
      Console.WriteLine("         Pastry Order: {0:C}", pastryCost);
      Console.WriteLine("     Total Order Cost: {0:C}", breadCost + pastryCost);
      Console.WriteLine(" ---------------------------------------------");


    }
  }
}