using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDZ7
{
    public interface IRealty 
    {
        static string Realty { get; }
        string Adress { get; set; } // адрес 
        int Room { get; set; } // комнаты 
        double Square { get; set; } // площадь недвижимости
        void Move (); 
    }
 
}
