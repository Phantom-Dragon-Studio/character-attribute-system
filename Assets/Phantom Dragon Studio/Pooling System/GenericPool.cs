using System;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    [Serializable]
    public abstract class GenericPool<T> : ScriptableObject
    {
        [SerializeField] protected int startCount = default;

        protected int StartCount => startCount;
        protected KeyValuePair<int, T> pointer;
        protected Dictionary<int, T> pool = new Dictionary<int, T>();
        public abstract void GeneratePool();
        protected abstract T FactoryRequest();
    }
}
