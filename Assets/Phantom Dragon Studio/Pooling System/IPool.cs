using System;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public interface IPool<T>
    {
        void AddToPool(T type);
        T RemoveFromPool(Vector3 _position, Quaternion _rotation);
        // void GeneratePool();
        T FindInPool(int key);
    }   
}