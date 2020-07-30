using Bees.Core.Enums;

namespace Bees.Core
{
    public class WorkerBee : BeeBase
    {
        public override BeeType BeeType { get; } = BeeType.Worker;
        public override int PronouncedDeadPercentage { get; } = 70;
    }
}
