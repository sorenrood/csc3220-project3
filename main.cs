using System;

namespace Games
{
  class MainClass 
  {
    public static void Main (string[] args) 
		{
      Coin.Flip();
      Console.WriteLine($"Flipped {Coin.state}");
  	}
	}
}