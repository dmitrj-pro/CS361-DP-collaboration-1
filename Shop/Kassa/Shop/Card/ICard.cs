using System;

namespace Shop
{
	public interface ICard
	{
		string name();
		double reCount(int c);
		bool isNext(int count);
	}
}

