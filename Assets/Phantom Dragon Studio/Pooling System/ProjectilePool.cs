using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;


namespace PhantomDragonStudio.CombatMechanics
{
    [CreateAssetMenu(fileName = "New Projectile Pool", menuName = "Phantom Dragon Studio/Pooling/Projectile Pool")]
    [Serializable]
    public class ProjectilePool : ScriptableObject,  IPool<IProjectile>
    {
        [SerializeField] protected int startCount = default;
        [SerializeField] private Projectile projectilesToPool = default;
        [SerializeField] [ShowOnly] private int currentSize = default;
        private new KeyValuePair<int, IProjectile> pointer = new KeyValuePair<int, IProjectile>();
        private new Dictionary<int, IProjectile> pool = new Dictionary<int, IProjectile>();
        public Dictionary<int, IProjectile> Pool => pool;
        public void GeneratePool()
        {
            currentSize = 0;
            for (int j = 0; j < startCount; j++)
            {
                IProjectile newProjectile = FactoryRequest();
                AddToPool(newProjectile);
            }
        }

        public void AddToPool(IProjectile projectile)
        {
            if (!Pool.ContainsKey(projectile.GetHashCode()))
            {
                pool.Add(projectile.GetHashCode(), projectile);
                currentSize = Pool.Count;
                projectile.Deactivate();
                Debug.Log("Added to pool: " + projectile.GetHashCode().ToString());
            }else
                Debug.LogWarning("Attempting to add an already existing character to " + this);
        }


        public IProjectile RemoveFromPool()
        {
            if (pool.Count > 0)
            {
                pointer = pool.First();
                pool.Remove(pointer.Key);
                Debug.Log("Removed from pool: " + pointer.Value.GetHashCode().ToString());
                currentSize = Pool.Count;
                pointer.Value.Activate();
                return pointer.Value;
            }
            else
                Debug.LogWarning(this + " is trying to pull an object out of an empty pool.");
            return FactoryRequest();
        }

        protected IProjectile FactoryRequest()
        {
            Debug.Log("Factory Request: Projectile");
            return ProjectileFactory.Create(projectilesToPool, this);
        }
    }
}
