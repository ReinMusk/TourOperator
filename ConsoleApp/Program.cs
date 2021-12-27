using System;
using static Core.DataAccess;

namespace ConsoleApp
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
