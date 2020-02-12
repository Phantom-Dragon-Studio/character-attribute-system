using System.Linq;
using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class ProjectilePoolHandler : BasePoolHandler<ProjectilePool>
    {
        private void Awake()
        {
            for (int i = 0; i < Pools.Count; i++)
            {
                Pools[i].GeneratePool();
                foreach (var entry in Pools[i].Pool)
                {
                    // Debug.Log(entry.ToString());
                }
            }
            // Debug.Log(Pools[0].Pool.First().ToString());
        }
    }
}
