using System;

namespace Shop
{
	public interface IShop
	{
		bool add(string goods);
		void exit();
		void buy();
		void init(IUser u);
		int showSum();
		double showSumWithKard();
		string getCheck();
		IUser getUser();
		bool isLock();
		bool Lock();
		bool Lock(bool t);
	}
}

