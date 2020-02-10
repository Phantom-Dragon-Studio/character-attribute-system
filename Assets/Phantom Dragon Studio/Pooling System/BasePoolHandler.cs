using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace PhantomDragonStudio.PoolingSystem
{
    [Serializable]
    public abstract class BasePoolHandler<PoolType> : MonoBehaviour
    {
        [SerializeField] private List<PoolType> pools = default;
        public List<PoolType> Pools => pools;
    }
}
