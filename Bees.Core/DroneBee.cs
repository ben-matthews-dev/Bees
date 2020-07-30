using Bees.Core.Enums;

namespace Bees.Core
{
    public class DroneBee : BeeBase
    {
        public override BeeType BeeType { get; } = BeeType.Drone;
        public override int PronouncedDeadPercentage { get; } = 50;
    }
}
