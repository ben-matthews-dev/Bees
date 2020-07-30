using Bees.Core.Enums;

namespace Bees.Core
{
    public class QueenBee : BeeBase
    {
        public override BeeType BeeType { get; } = BeeType.Queen;
        public override int PronouncedDeadPercentage { get; } = 20;
    }
}
