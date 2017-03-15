using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    interface IBuilder
    {

        void execute_command(string comm);

        void execute_file(string filename);

        void init();
    }
}
