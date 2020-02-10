using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class CharacterPoolHandler : BasePoolHandler<CharacterPool>
    {
        private void Awake()
        {
            for (int i = 0; i < Pools.Count; i++)
            {
                Pools[i].GeneratePool();
            }
        }
    }
}
