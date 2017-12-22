using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator.Contracts
{
    interface IResultStatisticItem
    {
        uint Number { get; set; }

        double Sum { get; set; }
    }
}
