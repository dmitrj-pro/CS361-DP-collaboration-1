using System;

namespace Shop
{
	public interface IUserS
	{
		IUser registration(string name,string mail);

		IUser login(string name,string mail);

	}
}

