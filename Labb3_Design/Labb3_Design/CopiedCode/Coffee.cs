﻿using Labb3_Design.CopiedCode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Design.CopiedCode
{
    internal class Coffee : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm coffee is served.");
        }
    }
}
