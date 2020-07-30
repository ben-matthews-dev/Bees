using Bees.Core.Enums;

namespace Bees.Core
{
    public interface IBee
    {
        int Id { get; set; }
        float Health { get; set; }
        void Damage(int percentage);
        StatusType StatusType { get; set; }
        BeeType BeeType { get; }
        int PronouncedDeadPercentage { get; }
    }
}
