using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator.Contracts
{
    interface IJournalActionItem
    {
        DateTime Time { get; set; }

        uint InvokerNumber { get; set; }

        uint ReceiverNumber { get; set; }

        MobileAccountActionType ActionType { get; set; }
    }
}