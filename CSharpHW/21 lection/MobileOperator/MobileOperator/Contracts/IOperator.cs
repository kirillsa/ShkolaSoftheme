using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator.Contracts
{
    interface IOperator
    {
        void AddClient(MobileAccount account);

        void ShowStatistic();
    }
}