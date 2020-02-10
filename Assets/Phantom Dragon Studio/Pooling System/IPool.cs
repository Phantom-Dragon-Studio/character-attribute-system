using System;

namespace PhantomDragonStudio.PoolingSystem
{
    public interface IPool
    {
        void AddToPool<T>(T type);
    }   
}