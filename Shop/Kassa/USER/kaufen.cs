using System;

namespace Shop
{
	public class kaufen:IUser
	{
		private string _name;
		private string _mail;
		public kaufen(string name,string mail){
			_name=name;
			_mail = mail;
		}
		public string getName() {return _name; }

		public string getMail() {return _mail;}
	}
}

