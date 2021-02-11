using System;

namespace Games
{
	public class Coin 
	{
		public enum FlipState
		{
			NONE = 0,
			HEAD = 1, 
			TAIL = 2
		}
    public static FlipState state;
		public static void Flip() 
		{
			Random x = new Random();
      state = (FlipState)x.Next(3);
		}
	}
}