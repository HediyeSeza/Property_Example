using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car pride=new Car();
            pride.speed = 120;

            Console.WriteLine($"speed is {pride.speed}");
            Console.ReadKey();
        }
    }
}
