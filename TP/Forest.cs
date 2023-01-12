using System;
namespace TP
{
	public class Forest
	{
        public static int gain_wood = 10;
        public static int wood_cost = 1;
        public static int stone_cost = 2;

        public Forest()
        {
            Console.WriteLine("Forest Created");
        }

        public int cutWood(int villagers)
        {
            return villagers * gain_wood;
        }
    }
}

