using System;

namespace Shop
{
	class Point<X,Y>{
		public X x;
		public Y y;
		public Point(X x,Y y){
			this.x=x;
			this.y = y;
		}
	}
	public class Cards
	{
		static public Cards Card=new Cards("card_base.txt");

		private string card_base;
		private System.Collections.Generic.Dictionary<string,Point<int,int>> _base;
		private void loadCards(){
			if (System.IO.File.Exists (card_base)) {
				_base= new System.Collections.Generic.Dictionary<string, Point<int,int>> ();
				string[] data = System.IO.File.ReadAllLines (card_base);
				for (int i = 0; i < data.Length; i++) {
					string[] p = data [i].Split ('=');
					string[] tmp = p [1].Split (':');
					_base.Add (p[0], new Point<int,int>(int.Parse(tmp[0]),int.Parse(tmp[1])));
				}
			} else {
				throw new Exception ("System file " + card_base + " is not found.");
			}
		}
		public Cards(string file){
			card_base = file;
			loadCards();
		}
		private ICard ParseCard(int id){
			switch (id) {
			case 0:
				return new NullCard ();
			case 1:
				return new LampCard ();
			case 2:
				return new TransCard ();
			case 3:
				return new IntegralCard ();
			default:
				return new NullCard ();
			}
		}
		private void Save(){
			string str="";
			foreach (var x in _base) {
				str += x.Key + "=" + x.Value.x + ":" + x.Value.y + "\n";
			}
			System.IO.File.WriteAllText (card_base, str);
		}
		public ICard findCard(string name,string mail){
			string hash=name+mail;
			if (_base.ContainsKey (hash)) {
				return ParseCard (_base [hash].x);
			} else
				return new NullCard ();
		}
		public ICard findCard(IUser u){
			return findCard(u.getName(),u.getMail());
		}
		public void add(string name,string mail,int count){
			string hash=name+mail;
			int sum = count;
			int id_card = 0;
			if (_base.ContainsKey (hash)) {
				id_card = _base [hash].x;
				sum += _base [hash].y;
			}
			ICard c=ParseCard(id_card);
			while(c.isNext(sum))
				c=ParseCard(++id_card);
			if (_base.ContainsKey (hash)){
				_base[hash].y=sum;
				_base[hash].x=id_card;
			}else 
				_base.Add(hash,new Point<int, int>(id_card,sum));
			Save();
		}
		public void add(IUser u,int count){
			add(u.getName(),u.getMail(),count);
		}
		public bool isNewCard(string name,string mail,int count){
			string hash=name+mail;
			int sum = count;
			int id_card = 0;
			if (_base.ContainsKey (hash)) {
				id_card = _base [hash].x;
				sum += _base [hash].y;
			}
			ICard c=ParseCard(id_card);
			return c.isNext(sum);
		}
		public bool isNewCard(IUser u,int count){
			return isNewCard(u.getName(),u.getMail(),count);
		}
	}
}

