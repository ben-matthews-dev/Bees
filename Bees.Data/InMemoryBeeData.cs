using Bees.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bees.Data
{
    public class InMemoryBeeData : IBeeData
    {
        public List<IBee> Bees;

        public InMemoryBeeData()
        {
            Bees = new List<IBee>();
            CreateBees<QueenBee>();
            CreateBees<WorkerBee>();
            CreateBees<DroneBee>();
        }

        public void CreateBees<T>()
        {
            for (int i = 0; i < 10; i++)
            {
                Add((BeeBase)Activator.CreateInstance(typeof(T)));
            }
        }

        public IBee Add(IBee bee)
        {
            bee.Id = (Bees.Count == 0) ? 1 : Bees.Max(x => x.Id) + 1;
            Bees.Add(bee);
            return bee;
        }


        public IEnumerable<IBee> GetAll()
        {
            return Bees.AsEnumerable();
        }
    }
}
