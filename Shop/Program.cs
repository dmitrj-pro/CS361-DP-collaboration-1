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
			IBuilder b = new Kassa ();
			b.execute_file ("test_file.txt");
			Console.ReadLine ();
        }
    }
}
