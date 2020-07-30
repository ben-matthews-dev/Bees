using Bees.Core.Enums;

namespace Bees.Core
{
    public abstract class BeeBase : IBee
    {
        public int Id { get; set; }
        public float Health { get; set; } = 100;
        public StatusType StatusType { get; set; } = StatusType.Alive;
        public abstract BeeType BeeType { get; }
        public abstract int PronouncedDeadPercentage { get; }

        public void Damage(int percentage)
        {
            if (StatusType == StatusType.Dead) return;
            // Note: percentage parameter will never go above 80 due to 0-80 range set on argument.
            if (percentage < 0 || percentage > 100) return;

            // Subtracts the percentage of damage
            Health = Health * (100 - percentage) / 100;

            if (Health < PronouncedDeadPercentage)
            {
                StatusType = StatusType.Dead;
            }
        }
    }
}
