using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class TargetablePoolHandler : MonoBehaviour
    {
        [SerializeField] private TargetablePool[] pools = default;
        public TargetablePool[] Pools => pools;

        private void Awake()
        {
            for (int i = 0; i < pools.Length; i++)
            {
                Pools[i].GeneratePool();
            }
        }

        public ITargetable SearchAllPools(int InstanceID)
        {
            ITargetable foundIndex = null;
            for (int i = 0; i < pools.Length; i++)
            {
                foundIndex = Pools[i].FindInPool(InstanceID);
                if (foundIndex == null)
                    continue;
                else
                    i = pools.Length;
            }

            return foundIndex;
        }
    }
}