﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserAction action = new UserAction();
            action.Perform();
            ReadLine();
        }
    }
}
