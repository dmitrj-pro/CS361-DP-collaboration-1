using System;

namespace Shop
{
	public interface IParser
	{
		void init (string filename);

		int commandByName(string name);
	}
}

