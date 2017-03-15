using System;

namespace Shop
{
	public interface IShop
	{
		void add(string goods);
		void exit();
		void bay();
		void init(IUser u);
	}
}

