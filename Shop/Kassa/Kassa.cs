﻿using System;
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
		private IUser u;
		static private string filename="allCommand.txt";
		public Kassa(){
			_comm = easyParser.Parse (Kassa.filename);
			BD = new UsersBD ();
		}
        public void execute_command(string comm) {
			string[] parametr = comm.Split (' ');
			if (!_comm.ContainsKey (parametr [0])) {
				throw new Exception ("Command '" + parametr [0] + "' is not correct.");
			}
			int num = _comm [parametr[0]];
			switch (num) {
			case 0:
				u = BD.login (parametr [1], parametr [2]);
				break;
			case 1:
				u = BD.registration (parametr [1], parametr [2]);
				break;
			case 2:
				Console.WriteLine (u.getName ());
				break;
			case 3:
				Console.WriteLine (u.getMail ());
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
