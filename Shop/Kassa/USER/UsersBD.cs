using System;

namespace Shop
{
	public class UsersBD: IUserS
	{
		private static string filename="userBD.txt";
		private System.Collections.Generic.Dictionary<string,string> _BD;
		public UsersBD(){
			_BD=easyParser.ParseAllString(UsersBD.filename);
		}
		private void Save(){
			string str="";
			foreach (var x in _BD) {
				str += x.Key + "=" + x.Value + "\n";
			}
			System.IO.File.WriteAllText (UsersBD.filename, str);
		}
		public IUser login(string name,string mail){ 
			name=name+mail;
			if (_BD.ContainsKey (name)) {
				return new kaufen (name.Substring(0,name.Length-mail.Length), mail);
			} else {
				return null;
			}
		}

		public IUser registration(string name,string mail){
			name=name+mail;
			if (_BD.ContainsKey(name))
				return null;
			_BD.Add (name, mail);
			this.Save ();
			return new kaufen (name.Substring(0,name.Length-mail.Length), mail);
		}
	}
}

