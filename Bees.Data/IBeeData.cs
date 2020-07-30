using Bees.Core;
using System.Collections.Generic;

namespace Bees.Data
{
    public interface IBeeData
    {
        IEnumerable<IBee> GetAll();

        IBee Add(IBee bee);
    }
}
