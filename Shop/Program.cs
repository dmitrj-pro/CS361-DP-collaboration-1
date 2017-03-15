using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
			Dictionary<string,int> r = easyParser.Parse ("ParserTest.txt");
			foreach (var x in r) {
				Console.WriteLine (x.Key + " " + x.Value);
			}
			Console.WriteLine (r.ToString ());
			Console.WriteLine ("ss");
			Console.ReadLine ();
        }
    }
}
