using System;

namespace Shop
{
	public interface ICard
	{
		/// <summary>
		/// Именование карты
		/// </summary>
		string name();
		/// <summary>
		/// Пересчитать сумму с учететом скидки по карте
		/// </summary>
		/// <returns>Стоимость</returns>
		/// <param name="c">C.</param>
		double reCount(int c);
		/// <summary>
		/// Можно ли выдавать следующую карту
		/// </summary>
		/// <param name="count">Общая стоимость товаров</param>
		bool isNext(int count);
	}
}

