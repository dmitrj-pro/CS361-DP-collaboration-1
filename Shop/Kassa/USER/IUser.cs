using System;

namespace Shop
{
	public interface IUser
	{
		/// <summary>
		/// Имя пользователя
		/// </summary>
		/// <returns>The name.</returns>
		string getName();

		/// <summary>
		/// Почта пользователя
		/// </summary>
		/// <returns>The mail.</returns>
		string getMail();
	}
}

