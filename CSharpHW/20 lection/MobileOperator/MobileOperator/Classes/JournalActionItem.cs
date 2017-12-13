using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileOperator.Contracts;

namespace MobileOperator
{
    class JournalActionItem : IJournalActionItem
    {
        public DateTime Time { get; set; }

        public uint InvokerNumber { get; set; }

        public uint ReceiverNumber { get; set; }

        public MobileAccountActionType ActionType { get;  set; }
    }
}