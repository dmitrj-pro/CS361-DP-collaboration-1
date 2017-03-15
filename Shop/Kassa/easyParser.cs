using System;

namespace Shop
{
	public class easyParser	{
		static public System.Collections.Generic.Dictionary<string,int> Parse (string filename){
			if (System.IO.File.Exists (filename)) {
				System.Collections.Generic.Dictionary<string,int> _data = new System.Collections.Generic.Dictionary<string, int> ();
				string[] data = System.IO.File.ReadAllLines (filename);
				for (int i = 0; i < data.Length; i++) {
					string[] p = data [i].Split ('=');
					int f = int.Parse (p [1]);
					_data.Add (p[0], f);
				}
				return _data;
			} else {
				throw new Exception ("System file " + filename + " is not found.");
			}
		}
	}
}

