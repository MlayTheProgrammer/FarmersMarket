using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmers_MarketTemp
{
    interface IFarmer
    {
        string Food { get; set; }
        string Name { get; set; }
       new string fruitsAndVeggies(string food);
    }
}
