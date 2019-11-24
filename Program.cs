using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[]m args)
    {
      Console.WriteLine("Welcome to Money Calculator!");
      
      // Ask user for value convertion //
      Console.WriteLine("Wich amount are you going to convert? ");
      string totalValue = Console.ReadLine();
     
      // Convert String data type into Double //
      double total =             Convert.ToDouble(totalValue);
      Console.WriteLine($"You choose: {total}");
      
      // Gold Coin //
      int goldValue = 10;
      
      // Silver Coin //
      int silverValue = 5;
      
      // Times 'Fits' Gold Coins and Silver Coins //
      double goldCoins = Math.Floor(total / goldValue);
      double silverFits = Math.Floor(total / silverValue);
  
      // Remaining amount GOLD //
      double remainingAmountGold = total % goldValue;
   
      // Remaining amount SILVER //
      double silverCoins = Math.Floor(total / silverValue);
      
      double remainingAmount = total % silverValue;
      
      // Remaining amount //
      remainingAmount = total % silverValue;
      
      Console.WriteLine($"It fits: {goldCoins} gold coins inside this number and {silverFits} Silver Coins");
      
      Console.WriteLine($"Gold Value remaining:  {remainingAmountGold}");
      
      Console.WriteLine($"Silver Value remaining:  {remainingAmount}");


      
    }
  }
}
