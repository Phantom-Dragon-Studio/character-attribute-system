﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public interface IPool<T>
    {
        void AddToPool(T type);
        T RemoveFromPool(T type = default(T));
        T FindInPool(int key);
    }   
}