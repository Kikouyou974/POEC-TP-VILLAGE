using System;
namespace TP
{
    public class Village
    {
        private string _name;
        private Ressources _ressources;
        public House chefHome;
        public List<House> listHouse;
        private int _villagers => listHouse.Count * House.villagers;
        private Mine _mine;

        public Village(string name)
        {
            this._name = name;
            this._ressources = new Ressources();
            this.chefHome = new House();
            this.listHouse = new List<House>();
            this.listHouse.Add(this.chefHome);
            this._mine = new Mine();
        }

        public string GetName()
        {
            return this._name;
        }

        public int GetStones()
        {
            return this._ressources.GetStones();
        }

        public int GetWoods()
        {
            return this._ressources.GetWoods();
        }

        public void addHouse()
        {
            this.listHouse.Add(new House());
        }

        public void MineStone(int villagers)
        {
            this._ressources.UseStone(Mine.stone_cost * villagers);
            this._ressources.UseWoods(Mine.wood_cost * villagers);
            this._ressources.AddStone(this._mine.mineStone(villagers));
        }
    }
}

