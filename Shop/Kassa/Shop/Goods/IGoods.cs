using System;

namespace Shop
{
	public interface IGoods
	{
		/// <summary>
		/// Стоимость товара
		/// </summary>
		int cost();
		/// <summary>
		/// Наименование товара
		/// </summary>
		string name();

	}
}

