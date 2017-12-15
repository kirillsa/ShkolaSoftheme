using MobileOperator.Contracts;

namespace MobileOperator
{
    public class ResultStatisticItem : IResultStatisticItem
    {
        public uint Number { get; set; }

        public double Sum { get; set; }
    }
}