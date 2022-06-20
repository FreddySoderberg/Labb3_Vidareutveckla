using Labb3_Design.CopiedCode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Design.CopiedCode.Factory.Interface
{
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total);
    }
}
