using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
		static bool Debug=false;
        static void Main(string[] args)
        {
			IBuilder b = new Kassa ();
			if (Debug)
				b.execute_file ("test_file.txt");
			else {
				Console.WriteLine ("Hello!");
				while (true) {
					string com = Console.ReadLine ();
					b.execute_command (com);
					if (com.Equals ("exit")) {
						break;
					}
				}
			}

			Console.ReadLine ();
        }
    }
}
