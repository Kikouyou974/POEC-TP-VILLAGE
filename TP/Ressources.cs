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

		public void UseStone(int stones)
		{
			this._stones = (stones > this._stones) ? this._stones : this._stones - stones;
		}

        public void UseWoods(int woods)
        {
            this._woods = (woods > this._woods) ? this._woods : this._woods - woods;
        }

		public void AddStone(int stones)
		{
			this._stones += stones;
		}
    }
}

