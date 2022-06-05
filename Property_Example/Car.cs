using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Example
{
    internal class Car
    {
        private int _speed;
        public int speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > 120)
                {
                    Console.WriteLine("Danger Drive slowly");
                    _speed = 0;
                }
                else
                {
                    _speed = value;
                }
            }
        }
    }
}
