using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Kassa: IBuilder
    {
		private Dictionary<string,int> _comm;
		private UsersBD BD;
		private IShop _s;
		static private string filename="allCommand.txt";
		public Kassa(){
			_comm = easyParser.Parse (Kassa.filename);
			BD = new UsersBD ();
			_s = new Shop ("goods_base.txt");
		}
        public void execute_command(string comm) {
			if (comm.Equals (""))
				return;
			string[] parametr = comm.Split (' ');
			if (!_comm.ContainsKey (parametr [0])) {
				throw new Exception ("Command '" + parametr [0] + "' is not correct.");
			}
			int num = _comm [parametr[0]];
			switch (num) {
			case 0:
				{
					IUser u = BD.login (parametr [1], parametr [2]);
					_s.init (u);
				}
				break;
			case 1:
				{
					IUser u = BD.registration (parametr [1], parametr [2]);
					_s.init (u);
				}
				break;
			case 2:
				Console.WriteLine (_s.getUser().getName ());
				break;
			case 3:
				Console.WriteLine (_s.getUser().getMail ());
				break;
			case 4:
				string goods = "";
				for (int i = 1; i < parametr.Length; i++) {
					goods += parametr [i];
					if (i != parametr.Length - 1)
						goods += " ";
				}
				if (_s.add (goods))
					Console.WriteLine ("OK");
				else
					Console.WriteLine ("FAIL");
				break;
			case 5:
				Console.WriteLine (_s.getCheck ());
				break;
			case 6:
				_s.exit ();
				break;
			case 7:
				Console.WriteLine (_s.getCheck ());
				_s.buy ();
				break;
			case 8:
				_s.Lock ();
				break;
			default:
				throw new Exception ("Command " + comm + " is not found");
			}
		}

        public void execute_file(string filename) {
			if (!System.IO.File.Exists (filename)) {
				throw new Exception ("System file " + filename + " is not found");
			}
			string[] comms = System.IO.File.ReadAllLines (filename);
			for (int i = 0; i < comms.Length; i++) {
				Console.Write (comms [i]+": ");
				this.execute_command (comms [i]);
				Console.WriteLine ();
			}				
		}

        public void init() { }
    }
}
