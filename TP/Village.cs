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
        private Forest _forest;

        public Village(string name)
        {
            this._name = name;
            this._ressources = new Ressources();
            this.chefHome = new House();
            this.listHouse = new List<House>();
            this.listHouse.Add(this.chefHome);
            this._mine = new Mine();
            this._forest = new Forest();
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
            if (villagers > this._villagers)
            {
                Console.WriteLine("Il n'y a pas assez de villagois");
                return;
            }
            if (!this._ressources.UseStone(Mine.stone_cost * villagers) || this._ressources.UseWoods(Mine.wood_cost * villagers))
            {
                Console.WriteLine("Il n'y a pas assez de ressources");
            } else
            {
                this._ressources.AddStone(this._mine.mineStone(villagers));
            }
        }

        public void CutWood(int villagers)
        {
            if (villagers > this._villagers)
            {
                Console.WriteLine("Il n'y a pas assez de villagois");
                return;
            }
            if (!this._ressources.UseStone(Forest.stone_cost * villagers) || this._ressources.UseWoods(Forest.wood_cost * villagers))
            {
                Console.WriteLine("Il n'y a pas assez de ressources");
            } else
            {
                this._ressources.AddWood(this._forest.cutWood(villagers));
            }
        }

        public void BuildHouse(int nbr)
        {
            if (!this._ressources.UseStone(House.stone_cost * nbr) || this._ressources.UseWoods(House.wood_cost * nbr))
            {
                Console.WriteLine("Il n'y a pas assez de ressources");
            } else
            {
                for (int i = 0; i < nbr; i++)
                {
                    this.addHouse();
                }
            }
        }
    }
}

