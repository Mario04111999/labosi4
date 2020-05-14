using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_4
{ //Zadatak 4
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
