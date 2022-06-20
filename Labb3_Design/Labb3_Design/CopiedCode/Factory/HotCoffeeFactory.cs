﻿using Labb3_Design.CopiedCode.Factory.Interface;
using Labb3_Design.CopiedCode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Design.CopiedCode.Factory
{
    internal class HotCoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot coffee in your cup");
            return new Water();
        }
    }
}