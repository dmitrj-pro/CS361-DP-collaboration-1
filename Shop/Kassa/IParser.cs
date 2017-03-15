using System;

namespace Shop
{
	public interface IParser
	{
		void init (string filename);

		void commandByName(string name);
	}
}

