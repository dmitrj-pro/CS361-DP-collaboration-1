using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    interface IBuilder
    {
		/// <summary>
		/// Выполнить заданную команду
		/// </summary>
		/// <param name="comm">Comm.</param>
        void execute_command(string comm);

		/// <summary>
		/// Выполнить все команды из заданного файла
		/// </summary>
		/// <param name="filename">Filename.</param>
        void execute_file(string filename);

		/// <summary>
		/// Инициализация
		/// </summary>
        void init();
    }
}
