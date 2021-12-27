using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using static Core.DataAccess;

namespace Consolee
{
    class Program
    {
        static void Main()
        {
            var temp = GetAirplanes();
            foreach (var item in temp)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
