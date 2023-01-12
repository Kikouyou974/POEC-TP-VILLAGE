using System;
namespace TP
{
	public class Mine
	{
		public static int gain_stone = 10;
		public static int wood_cost = 1;
		public static int stone_cost = 2;

        public Mine()
		{
			Console.WriteLine("Mine Created");
		}

		public int mineStone(int villagers)
		{
			return villagers * gain_stone;
		}
	}
}

