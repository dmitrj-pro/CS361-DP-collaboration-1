using System;

namespace Shop
{
	public interface IUserS
	{
		/// <summary>
		/// Зарегистрировать пользователя
		/// </summary>
		/// <param name="name">Имя</param>
		/// <param name="mail">Почта</param>
		IUser registration(string name,string mail);

		/// <summary>
		/// Авторизация пользователя
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="mail">Mail.</param>
		IUser login(string name,string mail);

	}
}

