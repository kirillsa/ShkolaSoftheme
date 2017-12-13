using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator.Contracts
{
    interface IMobileAccount
    {
        void CallOut(MobileAccount callingTo);

        void MessageOut(MobileAccount messageTo);

        string CallIn(MobileAccount callFrom);

        string MessageIn(MobileAccount messageFrom);
    }
}
