using System;

namespace Shop
{
	public interface IShop
	{
		/// <summary>
		/// Добавить товар по имени в корзину
		/// </summary>
		/// <param name="goods">Имя товара</param>
		bool add(string goods);
		/// <summary>
		/// Завершение сеанса
		/// </summary>
		void exit();
		/// <summary>
		/// Совершить покупку
		/// </summary>
		void buy();
		/// <summary>
		/// Инициализация
		/// </summary>
		/// <param name="u">U.</param>
		void init(IUser u);
		/// <summary>
		/// Показать сумму без учета скидки
		/// </summary>
		/// <returns>The sum.</returns>
		int showSum();
		/// <summary>
		/// Показать стоимость с учетом скидки
		/// </summary>
		/// <returns>The sum with kard.</returns>
		double showSumWithKard();
		/// <summary>
		/// Получить чек покупки
		/// </summary>
		/// <returns>The check.</returns>
		string getCheck();
		/// <summary>
		/// Получить данные о текущем пользователе
		/// </summary>
		/// <returns>The user.</returns>
		IUser getUser();
		/// <summary>
		/// Нельзя ли добавлять товары?
		/// </summary>
		/// <returns><c>true</c>, if lock was ised, <c>false</c> otherwise.</returns>
		bool isLock();
		/// <summary>
		/// Заблокировать добавление товаров
		/// </summary>
		bool Lock();
		/// <summary>
		/// Заблокировать/Разблокировать добавление товаров
		/// </summary>
		/// <param name="t">If set to <c>true</c> t.</param>
		bool Lock(bool t);
		/// <summary>
		/// Список товаров, доступных в магазине
		/// </summary>
		String List();
		/// <summary>
		/// Список товаров, находящихся в корзине
		/// </summary>
		string Order();
	}
}

