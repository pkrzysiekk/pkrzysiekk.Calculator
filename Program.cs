﻿using System.Text.RegularExpressions;
using CalculatorLibrary;
namespace pkrzysiekk.CalculatorLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator();
            calculator.menu.showMenu();
        }

    }
}
