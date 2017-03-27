using System;

namespace Shop
{
	public class Shop:IShop
	{
		private System.Collections.Generic.List<IGoods> _list;

		private bool _lock=false;
		public bool isLock(){
			return _lock;
		}
		public bool Lock(){
			_lock=!_lock;
			return isLock ();
		}
		public bool Lock(bool t){
			_lock=t;
			return isLock ();
		}
		private IUser _u;
		static private System.Collections.Generic.Dictionary<string,int> _BASE;
		public Shop(string fileBase){
			if (_BASE == null) {
				_BASE = easyParser.Parse(fileBase);
			}
			_list = new System.Collections.Generic.List<IGoods> ();
		}
			
		public bool add(string goods){
			if (isLock())
				return false;
			if (!_BASE.ContainsKey(goods))
				throw new Exception ("Goods is not found");
			_list.Add(new Goods(goods,_BASE[goods]));
			return true;
		}
		public int showSum(){
			int res=0;
			foreach (var x in _list){
				res += x.cost ();
			}
			return res;
		}
		public double showSumWithKard(){
			ICard c=Cards.Card.findCard(_u.getName(),_u.getMail());
			return c.reCount(showSum());
		}
		public string getCheck(){
			string res="";
			int sum = 0;
			foreach(var x in _list){
				sum += x.cost ();
				res += x.name () + "\t\t\t" + x.cost ().ToString ()+"\n";
			}
			res += "-------------------------------------\n";
			res += "Sum: " + sum.ToString ()+"\n";
			ICard c = Cards.Card.findCard (_u.getName (), _u.getMail ());
			res += "Card: " + c.name () + "\n";
			res += "Sum with Card: " + showSumWithKard () + "\n";
			if (Cards.Card.isNewCard(_u,showSum()))
				res += "New Card!\n";
			return res;
		}
					
		public void exit(){
			_u=null;
			_list = null;
			Lock (false);
		}
		public void buy(){
			Cards.Card.add(_u,showSum());
			_list = null;
			Lock (false);
		}
		public void init(IUser u){
			_u=u;
		}
		public IUser getUser(){
			return _u;
		}
	}
}

