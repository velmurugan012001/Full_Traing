﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class EnumDemo
    {

        enum Colors {Red,Green,Blue};

        public void Display()
        {
            Colors color1 = Colors.Red;
            Colors color2 = Colors.Green;
            Colors color3 = Colors.Blue;

            Console.WriteLine("My car color is " + color3);
        }
    }
}
