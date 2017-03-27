using System;

namespace Shop
{
	public class Goods:IGoods
	{
		private int _cost;
		private string _name;
		public Goods(string name, int cost){
			if (cost < 0)
				throw new Exception ("Cost >! 0");
			_cost = cost;
			_name = name;
		}
		public Goods(string name, string cos){
			int cost=int.Parse(cos);
			if (cost < 0)
				throw new Exception ("Cost >! 0");
			_cost = cost;
			_name = name;
		}
		public int cost(){ return _cost; }
		public string name(){ return _name; }
	}
}

