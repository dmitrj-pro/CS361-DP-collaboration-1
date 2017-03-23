using System;

namespace Shop
{
	public interface IShop
	{
		void add(string goods);
		void exit();
		void buy();
		void init(IUser u);
	}
}

