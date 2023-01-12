using System;
namespace TP
{
	public class Ressources
	{
		private int _woods;
		private int _stones;

		public Ressources()
		{
			this._stones = 10;
			this._woods = 10;
		}

		public int GetWoods()
		{
			return this._woods;
		}

		public int GetStones()
		{
			return this._stones;
		}

		public bool UseStone(int stones)
		{
			bool enough = (stones > this._stones);

            this._stones = enough ? this._stones : this._stones - stones;
			return enough;
		}

        public bool UseWoods(int woods)
        {
            bool enough = (woods > this._woods);

            this._woods = enough ? this._woods : this._woods - woods;
			return enough;
		}

		public void AddStone(int stones)
		{
			this._stones += stones;
		}

        public void AddWood(int woods)
        {
            this._woods += woods;
        }

    }
}

